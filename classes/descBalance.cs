using System;
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
}
