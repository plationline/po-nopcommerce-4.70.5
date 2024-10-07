using Microsoft.AspNetCore.Mvc.Rendering;
using Nop.Web.Framework.Mvc.ModelBinding;
using Nop.Web.Framework.Models;
using System.ComponentModel.DataAnnotations;
using System;

namespace Nop.Plugin.Payments.PlatiOnline.Models
{
    public record ConfigurationModel : BaseNopModel
    {
        public int ActiveStoreScopeConfiguration { get; set; }

        [NopResourceDisplayName("Plugins.Payments.PlatiOnline.Fields.MerchantId")]
        public string Merchant_Id { get; set; }
        public bool Merchant_Id_OverrideForStore { get; set; }

        [NopResourceDisplayName("Plugins.Payments.PlatiOnline.Fields.PublicKey")]
        public string Public_Key { get; set; }
        public bool Public_Key_OverrideForStore { get; set; }

        [NopResourceDisplayName("Plugins.Payments.PlatiOnline.Fields.PrivateKey")]
        public string Private_Key { get; set; }
        public bool Private_Key_OverrideForStore { get; set; }

        [NopResourceDisplayName("Plugins.Payments.PlatiOnline.Fields.IvAuth")]
        public string IvAuth { get; set; }
        public bool IvAuth_OverrideForStore { get; set; }

        [NopResourceDisplayName("Plugins.Payments.PlatiOnline.Fields.IvItsn")]
        public string IvItsn { get; set; }
        public bool IvItsn_OverrideForStore { get; set; }

        [NopResourceDisplayName("Plugins.Payments.PlatiOnline.Fields.RON")]
        public bool RON { get; set; }
        public bool RON_OverrideForStore { get; set; }

        [NopResourceDisplayName("Plugins.Payments.PlatiOnline.Fields.EUR")]
        public bool EUR { get; set; }
        public bool EUR_OverrideForStore { get; set; }

        [NopResourceDisplayName("Plugins.Payments.PlatiOnline.Fields.USD")]
        public bool USD { get; set; }
        public bool USD_OverrideForStore { get; set; }

        [NopResourceDisplayName("Plugins.Payments.PlatiOnline.Fields.OtherCurrency")]
        public SelectList OtherCurrency { get; set; }
        public int OtherCurrencyId { get; set; }
        public bool OtherCurrencyId_OverrideForStore { get; set; }

        [NopResourceDisplayName("Plugins.Payments.PlatiOnline.Fields.Relay_Response_URL")]
        public string Relay_Response_URL { get; set; }
        public bool Relay_Response_URL_OverrideForStore { get; set; }

        [NopResourceDisplayName("Plugins.Payments.PlatiOnline.Fields.RelayMethod")]
        public SelectList RelayMethod { get; set; }
        public int RelayMethodId { get; set; }
        public bool RelayMethodId_OverrideForStore { get; set; }

        [NopResourceDisplayName("Plugins.Payments.PlatiOnline.Fields.TestMode")]
        public bool TestMode { get; set; }
        public bool TestMode_OverrideForStore { get; set; }

        [NopResourceDisplayName("Plugins.Payments.PlatiOnline.Fields.SSL")]
        public bool SSL { get; set; }
        public bool SSL_OverrideForStore { get; set; }

        public int TransactModeId { get; set; }        

        [NopResourceDisplayName("Plugins.Payments.PlatiOnline.Fields.TransactMode")]
        public SelectList TransactModeValues { get; set; }
        public bool TransactModeId_OverrideForStore { get; set; }

        [NopResourceDisplayName("Plugins.Payments.PlatiOnline.Fields.Log_Path")]
        public string Log_Path { get; set; }
        public bool Log_Path_OverrideForStore { get; set; }

        [NopResourceDisplayName("Plugins.Payments.PlatiOnline.Fields.PayLinkDayOfValability")]
        //[Range(1, 31, ErrorMessage = "Value muste be between 1 and 31.")]
        public string PayLinkDayOfValability { get; set; }
        public bool PayLinkDayOfValability_OverrideForStore { get; set; }

        [NopResourceDisplayName("Plugins.Payments.PlatiOnline.Fields.PayLinkStamp2Expire")]
        public string PayLinkStamp2Expire { get; set; }
        public bool PayLinkStamp2Expire_OverrideForStore { get; set; }
    }
}