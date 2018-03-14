using System;
using System.Runtime.Serialization;

namespace ActsModel.Model
{
    /// <summary>
    /// АКТ ПРОВЕРКИ ФЛ
    /// </summary>
    [DataContract]
    public class ActInpectationFl : ActCommon
    {
        /// <summary>
        /// Номер акта
        /// </summary>
        
        [DataMember]
        public string ActNum { get; set; }

        /// <summary>
        /// Дата составления акта
        /// “__”	____ 20__г
        /// </summary>
        [DataMember]
        public DateTime? DateTimeCreation { get; set; }

        /// <summary>
        /// Место составления
        /// </summary>
        [DataMember]
        public string PlaceActCreation { get; set; }

        /// <summary>
        /// (должность, Ф.И.О. должностного лица,составившего акт)
        /// </summary>
        [DataMember]
        public string ActCreator { get; set; }

        /// <summary>
        ///  на  основании  распоряжения 
        /// (наименование должности руководителя органа муниципального земельного контроля
        /// </summary>
        [DataMember]
        public string BaseOnOrder { get; set; }

        /// <summary>
        ///  от 
        /// “__”	____ 20__г
        /// </summary>
        [DataMember]
        public DateTime? BaseOnOrderDate { get; set; }

        /// <summary>
        /// Номер распоряжения?
        /// </summary>
        [DataMember]
        public string OrderNum { get; set; }

        /// <summary>
        /// в присутствии: 
        /// (Ф.И.О. проверяемого лица, законного представителя)
        /// </summary>
        [DataMember]
        public string AttendingPersonsInfo { get; set; }

        /// <summary>
        /// проведена ... проверка
        /// (плановая/внеплановая, документарная/выездная)
        /// </summary>
        [DataMember]
        public string CheckType { get; set; }

        /// <summary>
        /// по адресу
        /// </summary>
        [DataMember]
        public string AreaAddress { get; set; }

        /// <summary>
        /// площадью ... кв.м
        /// </summary>
        [DataMember]
        public string AreaSquare { get; set; }

        /// <summary>
        /// Используемом 
        /// (Ф.И.О., ИНН, адрес места жительства, паспортные данные)
        /// </summary>
        [DataMember]
        public string UserInfo { get; set; }

        /// <summary>
        /// Проверка проводилась с 
        /// “__”	____ 20__г
        /// </summary>
        [DataMember]
        public DateTime? CheckDateStart { get; set; }

        /// <summary>
        /// до
        /// “__”	____ 20__г
        /// </summary>
        [DataMember]
        public DateTime? CheckDateFinish { get; set; }

        /// <summary>
        /// Проверкой установлено: 
        /// (описание территории, строений, сооружений, ограждения, межевых знаков и т.д.)
        /// </summary>
        [DataMember]
        public string CheckResults { get; set; }

        /// <summary>
        /// Объяснения,   заявления  проверяемого  лица  (законного  представителя)  по
        /// результатам проведенной проверки соблюдения земельного законодательства:
        /// </summary>
        [DataMember]
        public string InspectedPersonInfo { get; set; }

        /// <summary>
        /// От  участников проверки поступили (не поступили) заявления:
        /// (содержание заявления)
        /// </summary>
        [DataMember]
        public string ApplicationContent { get; set; }

        /// <summary>
        /// В ходе проверки производились: 
        /// (обмер участка, фото-, видеосъемка и т.п.)
        /// </summary>
        [DataMember]
        public string DuringCheckActivity { get; set; }

        /// <summary>
        /// К акту прилагается: 
        /// </summary>
        [DataMember]
        public string AdditionsToAct { get; set; }
    }
}
