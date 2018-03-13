using System;

namespace ActsModel.Model
{
    // АКТ ПРОВЕРКИ ФЛ
    public class ActInpectationFl
    {
        // Номер акта
        public string ActNum;

        // Дата составления акта
        // “__”	____ 20__г
        public DateTime DateCreation;

        // Место составления
        public string PlaceActCreation;

        // Время составления акта
        public string ActTimeCreation;

        // (должность, Ф.И.О. должностного лица,составившего акт)
        public string ActCreator;

        // на  основании  распоряжения 
        // (наименование должности руководителя органа муниципального земельного контроля
        public string BaseOnOrder;

        // от 
        // “__”	____ 20__г
        public DateTime BaseOnOrderDate;

        // Номер распоряжения?
        public string OrderNum;

        // в присутствии: 
        // (Ф.И.О. проверяемого лица, законного представителя)
        public string AttendingPersonsInfo;

        // проведена ... проверка
        // (плановая/внеплановая, документарная/выездная)
        public string CheckType;

        // по адресу
        public string AreaAddress;

        // площадью ... кв.м
        public string AreaSquare;

        // Используемом 
        // (Ф.И.О., ИНН, адрес места жительства, паспортные данные)
        public string UserInfo;

        // Проверка проводилась с 
        // “__”	____ 20__г
        public DateTime CheckDateStart;

        // до
        // “__”	____ 20__г
        public DateTime CheckDateFinish;

        // Проверкой установлено: 
        // (описание территории, строений, сооружений, ограждения, межевых знаков и т.д.)
        public string CheckResults;

        // Объяснения,   заявления  проверяемого  лица  (законного  представителя)  по
        // результатам проведенной проверки соблюдения земельного законодательства:
        public string InspectedPersonInfo;

        // От  участников проверки поступили (не поступили) заявления:
        // (содержание заявления)
        public string ApplicationContent;

        // В ходе проверки производились: 
        // (обмер участка, фото-, видеосъемка и т.п.)
        public string DuringCheckActivity;

        // К акту прилагается: 
        public string AdditionsToAct;
    }
}
