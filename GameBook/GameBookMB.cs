using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameBook
{
    public static class GameBookMB
    {
        public static DialogResult Show(string thongBao, string tieuDe, MessageBoxButtons button)
        {
            DialogResult dialogResult = DialogResult.None;
            switch (button)
            {
                case MessageBoxButtons.OK:
                    using (MessageOK msbOK = new MessageOK())
                    {
                        msbOK.Text = msbOK.Caption = tieuDe;
                        msbOK.Message = thongBao;
                        dialogResult = msbOK.ShowDialog();
                    }
                    break;
                case MessageBoxButtons.OKCancel:
                    break;
                case MessageBoxButtons.AbortRetryIgnore:
                    break;
                case MessageBoxButtons.YesNoCancel:
                    break;
                case MessageBoxButtons.YesNo:
                    using (MessageYesNo msbYesNo = new MessageYesNo())
                    {
                        msbYesNo.Text = msbYesNo.Caption = tieuDe;
                        msbYesNo.Message = thongBao;
                        dialogResult = msbYesNo.ShowDialog();
                    }
                    break;
                case MessageBoxButtons.RetryCancel:
                    break;
                default:
                    break;
            }
            return dialogResult;
        }
    }
}