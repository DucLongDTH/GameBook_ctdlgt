using GameBook.include.components;
using GameBook.include.objects;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Controls;
using System.Windows.Forms;

namespace GameBook
{
    public partial class MainBoard : Form
    {
        public MainBoard()
        {
            InitializeComponent();
            getGameData();
            lstSort.Visible = false;
            lstTypeSort.Visible = false;
            lstFilter.Visible = false;
            lbCountGame.Text = ds.Count.ToString();
            getGrid(ds);
        }
        Boolean checkHienThi;
        Boolean checkTimKiem = false;
        Boolean checkFilter = false;
        private static List<gameObject> ds = new List<gameObject>();

        private void getGameData()
        {
            SqlConnection ketnoi = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\SOURECODE\C# WINFORM\JOB-20200622T095042Z-001\JOB\GAMEBOOK\GAMEBOOK.MDF;Integrated Security=True");
            ketnoi.Open();
            SqlCommand cmd = new SqlCommand("Select * From Game;", ketnoi);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                string id = rd["ID"].ToString();
                string title = rd["TenGame"].ToString();
                string category = rd["TheLoai"].ToString();
                string version = rd["PhienBan"].ToString();
                string price = rd["Gia"].ToString();
                string releasedate = rd["NgayPhatHanh"].ToString();
                ds.Add(new gameObject(id, title, releasedate, version, category, price));
            }
            ketnoi.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        private void getGrid(List<gameObject> ds)
        {
            pnDisplay.Controls.Clear();
            for (int i = 0; i < ds.Count; i++)
            {
                Bitmap gì_đó = new Bitmap(Application.StartupPath + "\\img\\" + ds[i].GameID + ".jpg");
                gridMember a = new gridMember();
                a.gameLogo = gì_đó;
                a.gameTitle = ds[i].GameTitle;
                pnDisplay.Controls.Add(a);
                checkHienThi = true;
            }
        }
        private void btnGridView_Click(object sender, EventArgs e)
        {
            getGrid(ds);
            if (checkTimKiem == true) TimKiem();
            if (checkFilter == true) Filter();
        }
        private void getList(List<gameObject> ds)
        {
            pnDisplay.Controls.Clear();
            for (int i = 0; i < ds.Count; i++)
            {
                Bitmap gì_đó = new Bitmap(Application.StartupPath + "\\img\\" + ds[i].GameID + ".jpg");
                listMember a = new listMember();
                a.gameLogo = gì_đó;
                a.gameTitle = ds[i].GameTitle;
                a.gamePrice = ds[i].GamePrice;
                a.gameVersion = ds[i].GameVersion;
                a.releaseDate = ds[i].ReleaseDate;
                a.gameCategory = ds[i].GameCategory;
                pnDisplay.Controls.Add(a);
                checkHienThi = false;
            }
        }
        private void btnListView_Click(object sender, EventArgs e)
        {
            getList(ds);
            if (checkTimKiem == true) TimKiem();
            if (checkFilter == true) Filter();
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            lstSort.Visible = (!lstSort.Visible) ? true : false;

        }
        private void btnType_Click(object sender, EventArgs e)
        {
            lstTypeSort.Visible = lstTypeSort.Visible = (!lstTypeSort.Visible) ? true : false;
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            lstFilter.Visible = lstFilter.Visible = (!lstFilter.Visible) ? true : false;

        }
        private void label1_Click(object sender, EventArgs e)
        {
            lstSort.Visible = (!lstSort.Visible) ? true : false;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            lstTypeSort.Visible = lstTypeSort.Visible = (!lstTypeSort.Visible) ? true : false;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            lstFilter.Visible = lstFilter.Visible = (!lstFilter.Visible) ? true : false;
        }

        private void lstSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnSort.Text = lstSort.SelectedItem.ToString();
            if (lstSort.SelectedItem.ToString() == "Name")
            {
                lstTypeSort.Items.Clear();
                lstTypeSort.Items.Add("A - Z");
                lstTypeSort.Items.Add("Z - A");
            }
            if (lstSort.SelectedItem.ToString() == "Release Date")
            {
                lstTypeSort.Items.Clear();
                lstTypeSort.Items.Add("Newest");
                lstTypeSort.Items.Add("Oldest");
            }
            if (lstSort.SelectedItem.ToString() == "Price")
            {
                lstTypeSort.Items.Clear();
                lstTypeSort.Items.Add("Low - High");
                lstTypeSort.Items.Add("High - Low");
            }
            lstSort.Visible = false;
        }

        private void lstTypeSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnType.Text = lstTypeSort.SelectedItem.ToString();
            lstTypeSort.Visible = false;
        }

        private void lstFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnSort.Text =" Sort By";
            btnType.Text = "";
            btnFilter.Text = lstFilter.SelectedItem.ToString();
            lstFilter.Visible = false;
            checkFilter = true;
            Filter();
        }
        /* HÀM SO SÁNH TÊN */
        private int SortforABC(string str1, string str2)
        {
            int i = 0;
            int j = 0;
            char[] name1 = str1.ToCharArray();
            char[] name2 = str2.ToCharArray();
            while (i < name1.Length - 1 || j < name2.Length - 1)
            {
                int ma1 = (int)name1[i];
                int ma2 = (int)name2[j];
                if (ma1 < ma2)
                {
                    return -1; // name1 < name2 , name 1 nam trc

                }
                else if (ma1 > ma2)
                {
                    return 1; // name1 > name2 , name 2 nam trc

                }
                else
                {
                    i++;
                    j++;
                }
            }
            return 0;
        }
        /* HÀM SẮP XẾP TÊN A-Z */
        private void SX_ABC(List<gameObject> arr, int l, int r)
        {
            int i = l; int j = r;
            gameObject temp;
            gameObject pivot = arr[(int)(l + r) / 2];
            do
            {
                while (SortforABC(arr[i].GameTitle, pivot.GameTitle) == -1) i++;
                while (SortforABC(arr[j].GameTitle, pivot.GameTitle) == 1) j--;
                if (i <= j)
                {
                    temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                    i++;
                    j--;
                }

            } while (i < j);

            if (l < j) SX_ABC(arr, l, j);
            if (i < r) SX_ABC(arr, i, r);
        }
        /* HÀM SẮP XẾP TÊN Z-A */
        private void SX_CBA(List<gameObject> arr, int l, int r)
        {
            int i = l; int j = r;
            gameObject temp;
            gameObject pivot = arr[(int)(l + r) / 2];
            do
            {
                while (SortforABC(arr[i].GameTitle, pivot.GameTitle) == 1) i++;
                while (SortforABC(arr[j].GameTitle, pivot.GameTitle) == -1) j--;
                if (i <= j)
                {
                    temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                    i++;
                    j--;
                }

            } while (i < j);

            if (l < j) SX_CBA(arr, l, j);
            if (i < r) SX_CBA(arr, i, r);
        }
        /* Hàm So Sánh ngày tháng năm */
        private int sosanh_Date(string game_day1, string game_day2)
        {
            string[] day1 = game_day1.Split('/');
            string[] day2 = game_day2.Split('/');
            List<int> dsg1 = new List<int> { };
            List<int> dsg2 = new List<int> { };

            foreach (string item in day1)
            {
                int x = Convert.ToInt32(item);
                dsg1.Add(x);
            }
            foreach (string item in day2)
            {
                int x = Convert.ToInt32(item);
                dsg2.Add(x);
            }
            // so sanh theo nam 
            if (dsg1[2] > dsg2[2]) return 1;    // 2020 > 1999
            else if (dsg1[2] < dsg2[2]) return -1;     // 1999 < 2020
            else // 2020 = 2020 
            {
                if (dsg1[1] > dsg2[1]) return 1; // t8 > t7
                else if (dsg1[1] < dsg2[1]) return -1; // t8 < t7
                else // thang 8 = thang 8
                {
                    if (dsg1[0] > dsg2[0]) return 1; // ngay 31 > ngay 15
                    else if (dsg1[0] < dsg2[0]) return -1; // ngay 15 < ngay 31
                    else return 0; // trung nhau 
                }
            }
        }
        /* Hàm Sắp Xếp Date cũ */
        private void SX_old(List<gameObject> arr, int l, int r) // sap xep tang dan
        {
            int i = l;
            int j = r;
            gameObject temp;
            gameObject pivot = arr[(int)(l + r) / 2];
            do
            {
                while (sosanh_Date(arr[i].ReleaseDate, pivot.ReleaseDate) == -1) i++;
                while (sosanh_Date(arr[j].ReleaseDate, pivot.ReleaseDate) == 1) j--;

                if (i <= j)
                {
                    temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                    i++;
                    j--;
                }
            } while (i < j);

            if (l < j) SX_old(arr, l, j);
            if (i < r) SX_old(arr, i, r);
        }
        /* Hàm Sắp Xếp Date Mới */
        private void SX_new(List<gameObject> arr, int l, int r) // sap xep giam dan
        {
            int i = l;
            int j = r;
            gameObject temp;
            gameObject pivot = arr[(int)(l + r) / 2];
            do
            {
                while (sosanh_Date(arr[i].ReleaseDate, pivot.ReleaseDate) == 1) i++;
                while (sosanh_Date(arr[j].ReleaseDate, pivot.ReleaseDate) == -1) j--;

                if (i <= j)
                {
                    temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                    i++;
                    j--;
                }
            } while (i < j);
            // luc nay i > j chay l -> j va i -> r;
            if (l < j) SX_new(arr, l, j);
            if (i < r) SX_new(arr, i, r);
        }
        /* Hàm So Sánh  Giá */
        private static int so_sanh_Gia(string gia1, string gia2)
        {
            int g1 = int.Parse(gia1);
            int g2 = int.Parse(gia2);

            if (g1 > g2) return 1;
            else if (g1 < g2) return -1;
            return 0;
        }
        /* Hàm Sắp Xếp Giá Tăng Dần*/
        private static void Gia_Tang(List<gameObject> arr, int l, int r)
        {
            int i = l;
            int j = r;
            gameObject temp;
            gameObject pivot = arr[(int)(l + r) / 2];

            do
            {
                while (so_sanh_Gia(arr[i].GamePrice, pivot.GamePrice) == -1) i++;
                while (so_sanh_Gia(arr[j].GamePrice, pivot.GamePrice) == 1) j--;
                if (i <= j)
                {
                    temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                    i++;
                    j--;
                }

            } while (i < j);

            if (l < j) Gia_Tang(arr, l, j);
            if (i < r) Gia_Tang(arr, i, r);
        }
        /* Hàm Sắp Xếp Giá Giảm Dần*/
        private static void Gia_Giam(List<gameObject> arr, int l, int r)
        {
            int i = l;
            int j = r;
            gameObject temp;
            gameObject pivot = arr[(int)(l + r) / 2];

            do
            {
                while (so_sanh_Gia(arr[i].GamePrice, pivot.GamePrice) == 1) i++;
                while (so_sanh_Gia(arr[j].GamePrice, pivot.GamePrice) == -1) j--;
                if (i <= j)
                {
                    temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                    i++;
                    j--;

                }
            } while (i < j);

            if (l < j) Gia_Giam(arr, l, j);
            if (i < r) Gia_Giam(arr, i, r);
        }
        /* Hàm Tìm Kiếm Theo Tên */
        private void TimKiem()
        {
            pnDisplay.Controls.Clear();
            for (int i = 0; i < ds.Count; i++)
            {
                if (checkHienThi == true)
                {
                    if (ds[i].GameTitle.Contains(tbSearch.Text) == true)
                    {
                        Bitmap gì_đó = new Bitmap(Application.StartupPath + "\\img\\" + ds[i].GameID + ".jpg");
                        gridMember a = new gridMember();
                        a.gameLogo = gì_đó;
                        a.gameTitle = ds[i].GameTitle;
                        pnDisplay.Controls.Add(a);
                    }
                }
                else
                {
                    if (ds[i].GameTitle.Contains(tbSearch.Text) == true)
                    {
                        Bitmap gì_đó = new Bitmap(Application.StartupPath + "\\img\\" + ds[i].GameID + ".jpg");
                        listMember a = new listMember();
                        a.gameLogo = gì_đó;
                        a.gameTitle = ds[i].GameTitle;
                        a.gamePrice = ds[i].GamePrice;
                        a.gameVersion = ds[i].GameVersion;
                        a.releaseDate = ds[i].ReleaseDate;
                        a.gameCategory = ds[i].GameCategory;
                        pnDisplay.Controls.Add(a);
                    }
                }
            }
        }

        private List<gameObject> getAAA()
        {
            List<gameObject> temp = new List<gameObject>();
            pnDisplay.Controls.Clear();
            foreach (var item in ds)
            {
                if (item.GameCategory.Contains("AAA") == true)
                {
                    temp.Add(item);
                }
            }

            return temp;
        }
        private List<gameObject> getIndie()
        {
            List<gameObject> temp = new List<gameObject>();
            pnDisplay.Controls.Clear();
            foreach (var item in ds)
            {
                if (item.GameCategory.Contains("Indie") == true)
                {
                    temp.Add(item);
                }
            }

            return temp;
        }
        private void Filter()
        {
            List<gameObject> temp = new List<gameObject>();
            if (checkHienThi == true)
            {
                if (lstFilter.SelectedItem.ToString() == "AAA Only")
                {
                    temp = getAAA();
                    getGrid(temp);
                }
                else if (lstFilter.SelectedItem.ToString() == "Indie Only")
                {
                    temp = getIndie();
                    getGrid(temp);
                }
                else if (lstFilter.SelectedItem.ToString() == "AAA & Indie")
                {
                    getGrid(ds);
                }
            }
            else
            {

                if (lstFilter.SelectedItem.ToString() == "AAA Only")
                {
                    temp = getAAA();
                    getList(temp);
                }
                else if (lstFilter.SelectedItem.ToString() == "Indie Only")
                {
                    temp = getIndie();
                    getList(temp);
                }
                else if (lstFilter.SelectedItem.ToString() == "AAA & Indie")
                {
                    getList(ds);
                }
            }
        }
        private void btnExecSort_Click(object sender, EventArgs e)
        {
            tbSearch.Text = "";
            if (lstSort.SelectedItem == null || lstTypeSort.SelectedItem == null)
            {
                MessageBox.Show("CHƯA CHỌN SẮP XẾP , MỜI BẠN CHỌN !!!", " LỖI ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (lstSort.SelectedItem.ToString() == "Name" && lstTypeSort.SelectedItem.ToString() == "A - Z")
            {
                SX_ABC(ds, 0, ds.Count - 1);
                if (checkHienThi == true) getGrid(ds);
                else getList(ds);
            }
            else if (lstSort.SelectedItem.ToString() == "Name" && lstTypeSort.SelectedItem.ToString() == "Z - A")
            {
                SX_CBA(ds, 0, ds.Count - 1);
                if (checkHienThi == true) getGrid(ds);
                else getList(ds);
            }
            else if (lstSort.SelectedItem.ToString() == "Release Date" && lstTypeSort.SelectedItem.ToString() == "Newest")
            {
                SX_new(ds, 0, ds.Count - 1);
                if (checkHienThi == true) getGrid(ds);
                else getList(ds);
            }
            else if (lstSort.SelectedItem.ToString() == "Release Date" && lstTypeSort.SelectedItem.ToString() == "Oldest")
            {
                SX_old(ds, 0, ds.Count - 1);
                if (checkHienThi == true) getGrid(ds);
                else getList(ds);
            }
            else if (lstSort.SelectedItem.ToString() == "Price" && lstTypeSort.SelectedItem.ToString() == "Low - High")
            {
                Gia_Tang(ds, 0, ds.Count - 1);
                if (checkHienThi == true) getGrid(ds);
                else getList(ds);
            }
            else if (lstSort.SelectedItem.ToString() == "Price" && lstTypeSort.SelectedItem.ToString() == "High - Low")
            {
                Gia_Giam(ds, 0, ds.Count - 1);
                if (checkHienThi == true) getGrid(ds);
                else getList(ds);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            checkTimKiem = true;
            TimKiem();
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            checkTimKiem = true;
            TimKiem();
        }
    }
}
