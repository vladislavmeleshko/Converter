﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Converter.classes
{

    // Примечание. Для запуска созданного кода может потребоваться NET Framework версии 4.5 или более поздней версии и .NET Core или Standard версии 2.0 или более поздней.
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class descBalance
    {

        private string accTitleField;

        private string accountField;

        private byte rubValField;

        private ushort currCodeField;

        private string dateFromField;

        private string dateToField;

        private byte isErrorField;

        private descBalanceExtractList extractListField;

        private descBalanceEntry[] additionalParamsField;

        /// <remarks/>
        public string accTitle
        {
            get
            {
                return this.accTitleField;
            }
            set
            {
                this.accTitleField = value;
            }
        }

        /// <remarks/>
        public string account
        {
            get
            {
                return this.accountField;
            }
            set
            {
                this.accountField = value;
            }
        }

        /// <remarks/>
        public byte rubVal
        {
            get
            {
                return this.rubValField;
            }
            set
            {
                this.rubValField = value;
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
        public string dateFrom
        {
            get
            {
                return this.dateFromField;
            }
            set
            {
                this.dateFromField = value;
            }
        }

        /// <remarks/>
        public string dateTo
        {
            get
            {
                return this.dateToField;
            }
            set
            {
                this.dateToField = value;
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
        public descBalanceExtractList extractList
        {
            get
            {
                return this.extractListField;
            }
            set
            {
                this.extractListField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("entry", IsNullable = false)]
        public descBalanceEntry[] additionalParams
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
    }

    /// <remarks/>
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

        private uint unpField;

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
        public uint unp
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

    /// <remarks/>
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

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class descBalanceExtractListEntry
    {

        private string keyField;

        private string valueField;

        /// <remarks/>
        public string key
        {
            get
            {
                return this.keyField;
            }
            set
            {
                this.keyField = value;
            }
        }

        /// <remarks/>
        public string value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class descBalanceEntry
    {

        private string keyField;

        private string valueField;

        /// <remarks/>
        public string key
        {
            get
            {
                return this.keyField;
            }
            set
            {
                this.keyField = value;
            }
        }

        /// <remarks/>
        public string value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }


}
