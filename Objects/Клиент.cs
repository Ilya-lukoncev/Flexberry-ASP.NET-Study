﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IIS.Inter_002
{
    using System;
    using System.Xml;
    using ICSSoft.STORMNET;
    
    
    // *** Start programmer edit section *** (Using statements)

    // *** End programmer edit section *** (Using statements)


    /// <summary>
    /// Клиент.
    /// </summary>
    // *** Start programmer edit section *** (Клиент CustomAttributes)

    // *** End programmer edit section *** (Клиент CustomAttributes)
    [AutoAltered()]
    [AccessType(ICSSoft.STORMNET.AccessType.none)]
    [View("КлиентE", new string[] {
            "КодКлиента as \'Код клиента\'",
            "ФИО as \'ФИО\'",
            "Город as \'Город\'",
            "Улица as \'Улица\'",
            "Дом as \'Дом\'",
            "Квартира as \'Квартира\'",
            "ПочтовыйИндекс as \'Почтовый индекс\'",
            "Телефон as \'Телефон\'"})]
    [View("КлиентL", new string[] {
            "КодКлиента as \'Код клиента\'",
            "ФИО as \'ФИО\'",
            "Город as \'Город\'",
            "Улица as \'Улица\'",
            "Дом as \'Дом\'",
            "Квартира as \'Квартира\'",
            "ПочтовыйИндекс as \'Почтовый индекс\'",
            "Телефон as \'Телефон\'"})]
    public class Клиент : ICSSoft.STORMNET.DataObject
    {
        
        private int fКодКлиента;
        
        private string fФИО;
        
        private string fГород;
        
        private string fУлица;
        
        private string fДом;
        
        private string fКвартира;
        
        private string fПочтовыйИндекс;
        
        private string fТелефон;
        
        // *** Start programmer edit section *** (Клиент CustomMembers)

        // *** End programmer edit section *** (Клиент CustomMembers)

        
        /// <summary>
        /// КодКлиента.
        /// </summary>
        // *** Start programmer edit section *** (Клиент.КодКлиента CustomAttributes)

        // *** End programmer edit section *** (Клиент.КодКлиента CustomAttributes)
        public virtual int КодКлиента
        {
            get
            {
                // *** Start programmer edit section *** (Клиент.КодКлиента Get start)

                // *** End programmer edit section *** (Клиент.КодКлиента Get start)
                int result = this.fКодКлиента;
                // *** Start programmer edit section *** (Клиент.КодКлиента Get end)

                // *** End programmer edit section *** (Клиент.КодКлиента Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Клиент.КодКлиента Set start)

                // *** End programmer edit section *** (Клиент.КодКлиента Set start)
                this.fКодКлиента = value;
                // *** Start programmer edit section *** (Клиент.КодКлиента Set end)

                // *** End programmer edit section *** (Клиент.КодКлиента Set end)
            }
        }
        
        /// <summary>
        /// ФИО.
        /// </summary>
        // *** Start programmer edit section *** (Клиент.ФИО CustomAttributes)

        // *** End programmer edit section *** (Клиент.ФИО CustomAttributes)
        [StrLen(255)]
        public virtual string ФИО
        {
            get
            {
                // *** Start programmer edit section *** (Клиент.ФИО Get start)

                // *** End programmer edit section *** (Клиент.ФИО Get start)
                string result = this.fФИО;
                // *** Start programmer edit section *** (Клиент.ФИО Get end)

                // *** End programmer edit section *** (Клиент.ФИО Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Клиент.ФИО Set start)

                // *** End programmer edit section *** (Клиент.ФИО Set start)
                this.fФИО = value;
                // *** Start programmer edit section *** (Клиент.ФИО Set end)

                // *** End programmer edit section *** (Клиент.ФИО Set end)
            }
        }
        
        /// <summary>
        /// Город.
        /// </summary>
        // *** Start programmer edit section *** (Клиент.Город CustomAttributes)

        // *** End programmer edit section *** (Клиент.Город CustomAttributes)
        [StrLen(255)]
        public virtual string Город
        {
            get
            {
                // *** Start programmer edit section *** (Клиент.Город Get start)

                // *** End programmer edit section *** (Клиент.Город Get start)
                string result = this.fГород;
                // *** Start programmer edit section *** (Клиент.Город Get end)

                // *** End programmer edit section *** (Клиент.Город Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Клиент.Город Set start)

                // *** End programmer edit section *** (Клиент.Город Set start)
                this.fГород = value;
                // *** Start programmer edit section *** (Клиент.Город Set end)

                // *** End programmer edit section *** (Клиент.Город Set end)
            }
        }
        
        /// <summary>
        /// Улица.
        /// </summary>
        // *** Start programmer edit section *** (Клиент.Улица CustomAttributes)

        // *** End programmer edit section *** (Клиент.Улица CustomAttributes)
        [StrLen(255)]
        public virtual string Улица
        {
            get
            {
                // *** Start programmer edit section *** (Клиент.Улица Get start)

                // *** End programmer edit section *** (Клиент.Улица Get start)
                string result = this.fУлица;
                // *** Start programmer edit section *** (Клиент.Улица Get end)

                // *** End programmer edit section *** (Клиент.Улица Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Клиент.Улица Set start)

                // *** End programmer edit section *** (Клиент.Улица Set start)
                this.fУлица = value;
                // *** Start programmer edit section *** (Клиент.Улица Set end)

                // *** End programmer edit section *** (Клиент.Улица Set end)
            }
        }
        
        /// <summary>
        /// Дом.
        /// </summary>
        // *** Start programmer edit section *** (Клиент.Дом CustomAttributes)

        // *** End programmer edit section *** (Клиент.Дом CustomAttributes)
        [StrLen(255)]
        public virtual string Дом
        {
            get
            {
                // *** Start programmer edit section *** (Клиент.Дом Get start)

                // *** End programmer edit section *** (Клиент.Дом Get start)
                string result = this.fДом;
                // *** Start programmer edit section *** (Клиент.Дом Get end)

                // *** End programmer edit section *** (Клиент.Дом Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Клиент.Дом Set start)

                // *** End programmer edit section *** (Клиент.Дом Set start)
                this.fДом = value;
                // *** Start programmer edit section *** (Клиент.Дом Set end)

                // *** End programmer edit section *** (Клиент.Дом Set end)
            }
        }
        
        /// <summary>
        /// Квартира.
        /// </summary>
        // *** Start programmer edit section *** (Клиент.Квартира CustomAttributes)

        // *** End programmer edit section *** (Клиент.Квартира CustomAttributes)
        [StrLen(255)]
        public virtual string Квартира
        {
            get
            {
                // *** Start programmer edit section *** (Клиент.Квартира Get start)

                // *** End programmer edit section *** (Клиент.Квартира Get start)
                string result = this.fКвартира;
                // *** Start programmer edit section *** (Клиент.Квартира Get end)

                // *** End programmer edit section *** (Клиент.Квартира Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Клиент.Квартира Set start)

                // *** End programmer edit section *** (Клиент.Квартира Set start)
                this.fКвартира = value;
                // *** Start programmer edit section *** (Клиент.Квартира Set end)

                // *** End programmer edit section *** (Клиент.Квартира Set end)
            }
        }
        
        /// <summary>
        /// ПочтовыйИндекс.
        /// </summary>
        // *** Start programmer edit section *** (Клиент.ПочтовыйИндекс CustomAttributes)

        // *** End programmer edit section *** (Клиент.ПочтовыйИндекс CustomAttributes)
        [StrLen(255)]
        public virtual string ПочтовыйИндекс
        {
            get
            {
                // *** Start programmer edit section *** (Клиент.ПочтовыйИндекс Get start)

                // *** End programmer edit section *** (Клиент.ПочтовыйИндекс Get start)
                string result = this.fПочтовыйИндекс;
                // *** Start programmer edit section *** (Клиент.ПочтовыйИндекс Get end)

                // *** End programmer edit section *** (Клиент.ПочтовыйИндекс Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Клиент.ПочтовыйИндекс Set start)

                // *** End programmer edit section *** (Клиент.ПочтовыйИндекс Set start)
                this.fПочтовыйИндекс = value;
                // *** Start programmer edit section *** (Клиент.ПочтовыйИндекс Set end)

                // *** End programmer edit section *** (Клиент.ПочтовыйИндекс Set end)
            }
        }
        
        /// <summary>
        /// Телефон.
        /// </summary>
        // *** Start programmer edit section *** (Клиент.Телефон CustomAttributes)

        // *** End programmer edit section *** (Клиент.Телефон CustomAttributes)
        [StrLen(255)]
        public virtual string Телефон
        {
            get
            {
                // *** Start programmer edit section *** (Клиент.Телефон Get start)

                // *** End programmer edit section *** (Клиент.Телефон Get start)
                string result = this.fТелефон;
                // *** Start programmer edit section *** (Клиент.Телефон Get end)

                // *** End programmer edit section *** (Клиент.Телефон Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Клиент.Телефон Set start)

                // *** End programmer edit section *** (Клиент.Телефон Set start)
                this.fТелефон = value;
                // *** Start programmer edit section *** (Клиент.Телефон Set end)

                // *** End programmer edit section *** (Клиент.Телефон Set end)
            }
        }
        
        /// <summary>
        /// Class views container.
        /// </summary>
        public class Views
        {
            
            /// <summary>
            /// "КлиентE" view.
            /// </summary>
            public static ICSSoft.STORMNET.View КлиентE
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("КлиентE", typeof(IIS.Inter_002.Клиент));
                }
            }
            
            /// <summary>
            /// "КлиентL" view.
            /// </summary>
            public static ICSSoft.STORMNET.View КлиентL
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("КлиентL", typeof(IIS.Inter_002.Клиент));
                }
            }
        }
    }
}
