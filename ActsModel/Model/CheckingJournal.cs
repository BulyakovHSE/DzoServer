﻿using System.Runtime.Serialization;

namespace ActsModel.Model
{
    /// <summary>
    /// ЖУРНАЛ УЧЕТА ПРОВЕРОК ЮЛ ИП
    /// с названиями туго, ибо в одну строку уж много всякой разной инфы может попасть
    /// </summary>
    [DataContract]
    public class CheckingJournal : ActIndividual
    {
        /// <summary>
        ///  дата начала ведения журнала
        /// </summary>
        public string JournalStartDate;

        /// <summary>
        /// наименование юридического лица/фамилия, имя,
        /// индивидуального предпринимателя
        /// </summary>
        public string PersonInfo;

        /// <summary>
        ///  адрес (место нахождения) постоянно действующего исполнительного органа 
        /// юридического лица/место жительства (место осуществления деятельности 
        /// (если не совпадает с местом жительства) индивидуального предпринимателя)
        /// </summary>
        public string Address;

        /// <summary>
        /// (государственный регистрационный номер записи о государственной регистрации юридического лица/индивидуального предпринимателя, 
        /// идентификационный номер налогоплательщика (для индивидуального предпринимателя); 
        /// номер реестровой записи и дата включения сведений в реестр субъектов малого или среднего предпринимательства 
        /// для субъектов малого и среднего предпринимательства
        /// </summary>
        public string DifferentInfo;

        /// <summary>
        /// Ответственное лицо:
        /// (фамилия, имя, отчество (в случае, если имеется), должность лица (лиц), ответственного
        /// за ведение журнала учета проверок)
        /// </summary>
        public string ResponsiblePersonInfo;

        /// <summary>
        /// (фамилия, имя, отчество (в случае, если имеется) руководителя юридического лица, индивидуального предпринимателя)
        /// </summary>
        public string ResponsiblePersonBossInfo;

        /// <summary>
        ///  Дата начала и окончания проверки
        /// </summary>
        public string CheckDateStartAndFinish;

        /// <summary>
        /// Общее время проведения проверки 
        /// (в отношении субъектов малого предпринимательства и микропредприятий указывается в часах)
        /// </summary>
        public string CommonCheckDuration;

        /// <summary>
        /// Наименование органа государственного контроля (надзора), наименование органа муниципального контроля
        /// </summary>
        public string StateControlName;

        /// <summary>
        /// Дата и номер распоряжения или приказа о проведении проверки
        /// </summary>
        public string DateNumOrOrderOfCheck;

        /// <summary>
        /// Цель, задачи и предмет проверки
        /// </summary>
        public string CheckAimTaskAndObject;

        /// <summary>
        /// Вид проверки (плановая или внеплановая):
        /// в отношении плановой проверки:
        /// – со ссылкой на ежегодный план проведения проверок;
        /// в отношении внеплановой выездной проверки:
        /// – с указанием на дату и номер решения прокурора о согласовании проведения проверки(в случае, если такое согласование необходимо)
        /// </summary>
        public string CheckType;

        /// <summary>
        /// Дата и номер акта, составленного по результатам проверки, 
        /// дата его вручения представителю юридического лица, индивидуальному предпринимателю
        /// </summary>
        public string DateNumOfCheckRes;

        /// <summary>
        /// Выявленные нарушения обязательных требований 
        /// (указываются содержание выявленного нарушения со ссылкой на положение нормативного правового акта, 
        /// которым установлено нарушенное требование, допустившее его лицо)
        /// </summary>
        public string FoundViolations;

        /// <summary>
        /// Дата, номер и содержание выданного предписания об устранении выявленных нарушений
        /// </summary>
        public string DateNumOfContentOfElimination;

        /// <summary>
        /// Фамилия, имя, отчество (в случае, если имеется), должность должностного лица (должностных лиц), проводящего(их) проверку
        /// </summary>
        public string CheckerPersonInfo;
    }
}
