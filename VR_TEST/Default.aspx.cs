using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VR_TEST.com.sslwireless.vrtest;

namespace VR_TEST
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            virtualrechargeService vr = new virtualrechargeService();

            // calling Create Recharge 
            RechargeResponseDataType response_create = vr.CreateRecharge("vr_sslw", "ZmVyZG91cw==", "GUID123456789020190725B", "1", "01722412196", "10", "prepaid", "from-web", "1", "", "");
            Response.Write(response_create.recharge_status);

            // calling Init Recharge
            RechargeResponseDataType response_init = vr.InitRecharge("vr_sslw", "ZmVyZG91cw==", "GUID123456789020190725B", response_create.vr_guid, "", "");
            Response.Write(response_init.recharge_status);

            // After 1 to 90 mnutes
            RechargeRequestDataType response_query = vr.QueryRechargeStatus("vr_sslw", "GUID123456789020190725B", response_create.vr_guid);
            Response.Write(response_query.recharge_status);

            //Calling Verify MSISDN
            String response_verify_msisdn = vr.VerifyMSISDN("vr_sslw", "01722412196");
            Response.Write(response_verify_msisdn);


        }
    }
}