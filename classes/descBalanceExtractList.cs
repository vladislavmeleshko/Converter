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
    public partial class descBalanceExtractList
    {

        private decimal openingBalanceField;

        private decimal openingBalanceNatField;

        private byte isOpeningBalanceDebitField;

        private decimal closingBalanceField;

        private decimal closingBalanceNatField;

        private byte isClosingBalanceDebitField;

        private decimal tDbAmountField;

        private decimal tDbAmountNatField;

        private decimal tCrAmountField;

        private decimal tCrAmountNatField;

        private string header1Field;

        private string header2Field;

        private string header3Field;

        private string header4Field;

        private string header5Field;

        private object header6Field;

        private System.DateTime dateTimeField;

        private System.DateTime openingBalanceDateField;

        private System.DateTime closingBalanceDateField;

        private byte accountTypeField;

        private string isoField;

        private ushort currCodeField;

        private ushort officerCodeField;

        private ushort officerNameField;

        private string answerField;

        private List<descBalanceExtractListTurns> turnsField;

        private List<descBalanceExtractListEntry> additionalParamsField;

        private byte isErrorField;

        private string unpField;

        private string clientNameField;

        private string userNameField;

        private string bankNameField;

        /// <remarks/>
        public decimal openingBalance
        {
            get
            {
                return this.openingBalanceField;
            }
            set
            {
                this.openingBalanceField = value;
            }
        }

        /// <remarks/>
        public decimal openingBalanceNat
        {
            get
            {
                return this.openingBalanceNatField;
            }
            set
            {
                this.openingBalanceNatField = value;
            }
        }

        /// <remarks/>
        public byte isOpeningBalanceDebit
        {
            get
            {
                return this.isOpeningBalanceDebitField;
            }
            set
            {
                this.isOpeningBalanceDebitField = value;
            }
        }

        /// <remarks/>
        public decimal closingBalance
        {
            get
            {
                return this.closingBalanceField;
            }
            set
            {
                this.closingBalanceField = value;
            }
        }

        /// <remarks/>
        public decimal closingBalanceNat
        {
            get
            {
                return this.closingBalanceNatField;
            }
            set
            {
                this.closingBalanceNatField = value;
            }
        }

        /// <remarks/>
        public byte isClosingBalanceDebit
        {
            get
            {
                return this.isClosingBalanceDebitField;
            }
            set
            {
                this.isClosingBalanceDebitField = value;
            }
        }

        /// <remarks/>
        public decimal tDbAmount
        {
            get
            {
                return this.tDbAmountField;
            }
            set
            {
                this.tDbAmountField = value;
            }
        }

        /// <remarks/>
        public decimal tDbAmountNat
        {
            get
            {
                return this.tDbAmountNatField;
            }
            set
            {
                this.tDbAmountNatField = value;
            }
        }

        /// <remarks/>
        public decimal tCrAmount
        {
            get
            {
                return this.tCrAmountField;
            }
            set
            {
                this.tCrAmountField = value;
            }
        }

        /// <remarks/>
        public decimal tCrAmountNat
        {
            get
            {
                return this.tCrAmountNatField;
            }
            set
            {
                this.tCrAmountNatField = value;
            }
        }

        /// <remarks/>
        public string header1
        {
            get
            {
                return this.header1Field;
            }
            set
            {
                this.header1Field = value;
            }
        }

        /// <remarks/>
        public string header2
        {
            get
            {
                return this.header2Field;
            }
            set
            {
                this.header2Field = value;
            }
        }

        /// <remarks/>
        public string header3
        {
            get
            {
                return this.header3Field;
            }
            set
            {
                this.header3Field = value;
            }
        }

        /// <remarks/>
        public string header4
        {
            get
            {
                return this.header4Field;
            }
            set
            {
                this.header4Field = value;
            }
        }

        /// <remarks/>
        public string header5
        {
            get
            {
                return this.header5Field;
            }
            set
            {
                this.header5Field = value;
            }
        }

        /// <remarks/>
        public object header6
        {
            get
            {
                return this.header6Field;
            }
            set
            {
                this.header6Field = value;
            }
        }

        /// <remarks/>
        public System.DateTime dateTime
        {
            get
            {
                return this.dateTimeField;
            }
            set
            {
                this.dateTimeField = value;
            }
        }

        /// <remarks/>
        public System.DateTime openingBalanceDate
        {
            get
            {
                return this.openingBalanceDateField;
            }
            set
            {
                this.openingBalanceDateField = value;
            }
        }

        /// <remarks/>
        public System.DateTime closingBalanceDate
        {
            get
            {
                return this.closingBalanceDateField;
            }
            set
            {
                this.closingBalanceDateField = value;
            }
        }

        /// <remarks/>
        public byte accountType
        {
            get
            {
                return this.accountTypeField;
            }
            set
            {
                this.accountTypeField = value;
            }
        }

        /// <remarks/>
        public string iso
        {
            get
            {
                return this.isoField;
            }
            set
            {
                this.isoField = value;
            }
        }

        /// <remarks/>
        public ushort currCode
        {
            get
            {
                return this.currCodeField;
            }
            set
            {
                this.currCodeField = value;
            }
        }

        /// <remarks/>
        public ushort officerCode
        {
            get
            {
                return this.officerCodeField;
            }
            set
            {
                this.officerCodeField = value;
            }
        }

        /// <remarks/>
        public ushort officerName
        {
            get
            {
                return this.officerNameField;
            }
            set
            {
                this.officerNameField = value;
            }
        }

        /// <remarks/>
        public string answer
        {
            get
            {
                return this.answerField;
            }
            set
            {
                this.answerField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("turns")]
        public List<descBalanceExtractListTurns> turns
        {
            get
            {
                return this.turnsField;
            }
            set
            {
                this.turnsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("entry", IsNullable = false)]
        public List<descBalanceExtractListEntry> additionalParams
        {
            get
            {
                return this.additionalParamsField;
            }
            set
            {
                this.additionalParamsField = value;
            }
        }

        /// <remarks/>
        public byte isError
        {
            get
            {
                return this.isErrorField;
            }
            set
            {
                this.isErrorField = value;
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
        public string clientName
        {
            get
            {
                return this.clientNameField;
            }
            set
            {
                this.clientNameField = value;
            }
        }

        /// <remarks/>
        public string userName
        {
            get
            {
                return this.userNameField;
            }
            set
            {
                this.userNameField = value;
            }
        }

        /// <remarks/>
        public string bankName
        {
            get
            {
                return this.bankNameField;
            }
            set
            {
                this.bankNameField = value;
            }
        }
    }
}
