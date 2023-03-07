using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Converter.classes
{
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class descBalanceExtractListTurns
    {

        private decimal dbAmountField;

        private decimal dbAmountNatField;

        private decimal crAmountField;

        private decimal crAmountNatField;

        private System.DateTime docDateField;

        private string docNField;

        private string docIdField;

        private byte oprField;

        private string naznTextField;

        private object naznTextInvField;

        private string corrNameField;

        private string unpField;

        private string corrAccountField;

        private string corrBankCodeField;

        private string corrBankNameField;

        private object payerField;

        private object beneficiarField;

        private byte docTypeField;

        private object docStsField;

        private object addParamsField;

        /// <remarks/>
        public decimal dbAmount
        {
            get
            {
                return this.dbAmountField;
            }
            set
            {
                this.dbAmountField = value;
            }
        }

        /// <remarks/>
        public decimal dbAmountNat
        {
            get
            {
                return this.dbAmountNatField;
            }
            set
            {
                this.dbAmountNatField = value;
            }
        }

        /// <remarks/>
        public decimal crAmount
        {
            get
            {
                return this.crAmountField;
            }
            set
            {
                this.crAmountField = value;
            }
        }

        /// <remarks/>
        public decimal crAmountNat
        {
            get
            {
                return this.crAmountNatField;
            }
            set
            {
                this.crAmountNatField = value;
            }
        }

        /// <remarks/>
        public System.DateTime docDate
        {
            get
            {
                return this.docDateField;
            }
            set
            {
                this.docDateField = value;
            }
        }

        /// <remarks/>
        public string docN
        {
            get
            {
                return this.docNField;
            }
            set
            {
                this.docNField = value;
            }
        }

        /// <remarks/>
        public string docId
        {
            get
            {
                return this.docIdField;
            }
            set
            {
                this.docIdField = value;
            }
        }

        /// <remarks/>
        public byte opr
        {
            get
            {
                return this.oprField;
            }
            set
            {
                this.oprField = value;
            }
        }

        /// <remarks/>
        public string naznText
        {
            get
            {
                return this.naznTextField;
            }
            set
            {
                this.naznTextField = value;
            }
        }

        /// <remarks/>
        public object naznTextInv
        {
            get
            {
                return this.naznTextInvField;
            }
            set
            {
                this.naznTextInvField = value;
            }
        }

        /// <remarks/>
        public string corrName
        {
            get
            {
                return this.corrNameField;
            }
            set
            {
                this.corrNameField = value;
            }
        }

        /// <remarks/>
        public string unp
        {
            get
            {
                return this.unpField;
            }
            set
            {
                this.unpField = value;
            }
        }

        /// <remarks/>
        public string corrAccount
        {
            get
            {
                return this.corrAccountField;
            }
            set
            {
                this.corrAccountField = value;
            }
        }

        /// <remarks/>
        public string corrBankCode
        {
            get
            {
                return this.corrBankCodeField;
            }
            set
            {
                this.corrBankCodeField = value;
            }
        }

        /// <remarks/>
        public string corrBankName
        {
            get
            {
                return this.corrBankNameField;
            }
            set
            {
                this.corrBankNameField = value;
            }
        }

        /// <remarks/>
        public object payer
        {
            get
            {
                return this.payerField;
            }
            set
            {
                this.payerField = value;
            }
        }

        /// <remarks/>
        public object beneficiar
        {
            get
            {
                return this.beneficiarField;
            }
            set
            {
                this.beneficiarField = value;
            }
        }

        /// <remarks/>
        public byte docType
        {
            get
            {
                return this.docTypeField;
            }
            set
            {
                this.docTypeField = value;
            }
        }

        /// <remarks/>
        public object docSts
        {
            get
            {
                return this.docStsField;
            }
            set
            {
                this.docStsField = value;
            }
        }

        /// <remarks/>
        public object addParams
        {
            get
            {
                return this.addParamsField;
            }
            set
            {
                this.addParamsField = value;
            }
        }
    }
}
