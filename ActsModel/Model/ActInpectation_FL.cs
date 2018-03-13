using System;

namespace ActsModel.Model
{
    /// <summary>
    /// АКТ ПРОВЕРКИ ФЛ
    /// </summary>
    public class ActInpectationFl : ActCommon
    {
        /// <summary>
        /// Номер акта
        /// </summary>
        public string ActNum;

        /// <summary>
        /// Дата составления акта
        /// “__”	____ 20__г
        /// </summary>
        public DateTime DateCreation;

        /// <summary>
        /// Место составления
        /// </summary>
        public string PlaceActCreation;

        /// <summary>
        /// Время составления акта
        /// </summary>
        public string ActTimeCreation;

        /// <summary>
        /// (должность, Ф.И.О. должностного лица,составившего акт)
        /// </summary>
        public string ActCreator;

        /// <summary>
        ///  на  основании  распоряжения 
        /// (наименование должности руководителя органа муниципального земельного контроля
        /// </summary>
        public string BaseOnOrder;

        /// <summary>
        ///  от 
        /// “__”	____ 20__г
        /// </summary>
        public DateTime BaseOnOrderDate;

        /// <summary>
        /// Номер распоряжения?
        /// </summary>
        public string OrderNum;

        /// <summary>
        /// в присутствии: 
        /// (Ф.И.О. проверяемого лица, законного представителя)
        /// </summary>
        public string AttendingPersonsInfo;

        /// <summary>
        /// проведена ... проверка
        /// (плановая/внеплановая, документарная/выездная)
        /// </summary>
        public string CheckType;

        /// <summary>
        /// по адресу
        /// </summary>
        public string AreaAddress;

        /// <summary>
        /// площадью ... кв.м
        /// </summary>
        public string AreaSquare;

        /// <summary>
        /// Используемом 
        /// (Ф.И.О., ИНН, адрес места жительства, паспортные данные)
        /// </summary>
        public string UserInfo;

        /// <summary>
        /// Проверка проводилась с 
        /// “__”	____ 20__г
        /// </summary>
        public DateTime CheckDateStart;

        /// <summary>
        /// до
        /// “__”	____ 20__г
        /// </summary>
        public DateTime CheckDateFinish;

        /// <summary>
        /// Проверкой установлено: 
        /// (описание территории, строений, сооружений, ограждения, межевых знаков и т.д.)
        /// </summary>
        public string CheckResults;

        /// <summary>
        /// Объяснения,   заявления  проверяемого  лица  (законного  представителя)  по
        /// результатам проведенной проверки соблюдения земельного законодательства:
        /// </summary>
        public string InspectedPersonInfo;

        /// <summary>
        /// От  участников проверки поступили (не поступили) заявления:
        /// (содержание заявления)
        /// </summary>
        public string ApplicationContent;

        /// <summary>
        /// В ходе проверки производились: 
        /// (обмер участка, фото-, видеосъемка и т.п.)
        /// </summary>
        public string DuringCheckActivity;

        /// <summary>
        /// К акту прилагается: 
        /// </summary>
        public string AdditionsToAct;
    }
}
