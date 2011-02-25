using System;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BaseMaster {
    public partial class _Default : System.Web.UI.Page {

        protected void Page_Load(object sender, EventArgs e) {
            if (!IsPostBack) {
                ErrorMessage.Text = String.Empty;
            }
        }

        protected void Submit_Click(object sender, EventArgs e) {
            Validate();
            if (Page.IsValid) {
                string fromBase = ConvertFromList.SelectedValue;
                string toBase = ConvertToList.SelectedValue;
                string result = BaseUtility.Convert(UserNumber.Text.ToString(), Convert.ToInt32(ConvertFromList.SelectedValue), Convert.ToInt32(ConvertToList.SelectedValue));

                BaseResult.Text = String.Format("{0}<span class=\"subscript\">{1}</span> = {2}<span class=\"subscript\">{3}</span>", UserNumber.Text, fromBase, result, toBase).ToString();
            }
        }

        protected void CustomValidator_ServerValidate(object source, ServerValidateEventArgs args) {
            bool isValid = true;
            ErrorMessage.Text = String.Empty;
            BaseResult.Text = String.Empty;
            string errorText = ValidationUtility.Validate(UserNumber.Text, ConvertFromList.SelectedValue);

            if (!String.IsNullOrEmpty(errorText)) {
                ErrorMessage.Text = errorText;
                isValid = false;
            }

            args.IsValid = isValid;
        }

    }
}
