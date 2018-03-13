using System;

namespace ActsModel.Model
{
    // ПЛАН ПРОВЕРКИ ГРАЖДАН
    public class CitizensCheckPlan
    {
        // (наименование органа муниципального земельного контроля)
        public string TerritorialBodyName;

        // Утвержден
        // (Ф.И.О. и подпись руководителя органа муниципального земельного контроля)
        public string ApprovedByInfo;

        // От 
        // _______________ 20___ г.
        public DateTime ApprovedTime;

        // План проведения плановых проверок граждан на 
        // 20___ год
        public string ScheduledInspectionYear;

        // Объект земельных отношений, подлежащий проверке
        // кадастровый номер земельного участка, его площадь, категория, 
        // вид разрешенного использования и местоположение
        public string EarthObject;

        // Фамилия, имя, отчество (последнее при наличии) гражданина
        public string CitizenName;

        // Цель проведения проверки
        public string CheckAim;

        //Основание проведения проверки
        public string CheckBase;

        // Дата начала проведения проверки (Указывается календарный месяц начала проведения проверки.)
        public string CheckStartDate;

        // Срок проведения плановой проверки 
        // (рабочих дней)
        public string CheckDurationInDays;

        // Наименование федерального органа государственного земельного надзора, 
        // с которым проверка проводится совместно
        public string FederalBodyName;
    }
}
