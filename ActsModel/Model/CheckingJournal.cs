using System;
using System.Runtime.Serialization;

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
        [DataMember]
        public DateTime? JournalStartDate { get; set; }

        /// <summary>
        /// наименование юридического лица/фамилия, имя,
        /// индивидуального предпринимателя
        /// </summary>
        [DataMember]
        public string PersonInfo { get; set; }

        /// <summary>
        ///  адрес (место нахождения) постоянно действующего исполнительного органа 
        /// юридического лица/место жительства (место осуществления деятельности 
        /// (если не совпадает с местом жительства) индивидуального предпринимателя)
        /// </summary>
        [DataMember]
        public string Address { get; set; }

        /// <summary>
        /// (государственный регистрационный номер записи о государственной регистрации юридического лица/индивидуального предпринимателя, 
        /// идентификационный номер налогоплательщика (для индивидуального предпринимателя); 
        /// номер реестровой записи и дата включения сведений в реестр субъектов малого или среднего предпринимательства 
        /// для субъектов малого и среднего предпринимательства
        /// </summary>
        [DataMember]
        public string DifferentInfo { get; set; }

        /// <summary>
        /// Ответственное лицо:
        /// (фамилия, имя, отчество (в случае, если имеется), должность лица (лиц), ответственного
        /// за ведение журнала учета проверок)
        /// </summary>
        [DataMember]
        public string ResponsiblePersonInfo { get; set; }

        /// <summary>
        /// (фамилия, имя, отчество (в случае, если имеется) руководителя юридического лица, индивидуального предпринимателя)
        /// </summary>
        [DataMember]
        public string ResponsiblePersonBossInfo { get; set; }

        /// <summary>
        ///  Дата начала и окончания проверки
        /// </summary>
        [DataMember]
        public string CheckDateStartAndFinish { get; set; }

        /// <summary>
        /// Общее время проведения проверки 
        /// (в отношении субъектов малого предпринимательства и микропредприятий указывается в часах)
        /// </summary>
        [DataMember]
        public string CommonCheckDuration { get; set; }

        /// <summary>
        /// Наименование органа государственного контроля (надзора), наименование органа муниципального контроля
        /// </summary>
        [DataMember]
        public string StateControlName { get; set; }

        /// <summary>
        /// Дата и номер распоряжения или приказа о проведении проверки
        /// </summary>
        [DataMember]
        public string DateNumOrOrderOfCheck { get; set; }

        /// <summary>
        /// Цель, задачи и предмет проверки
        /// </summary>
        [DataMember]
        public string CheckAimTaskAndObject { get; set; }

        /// <summary>
        /// Вид проверки (плановая или внеплановая):
        /// в отношении плановой проверки:
        /// – со ссылкой на ежегодный план проведения проверок;
        /// в отношении внеплановой выездной проверки:
        /// – с указанием на дату и номер решения прокурора о согласовании проведения проверки(в случае, если такое согласование необходимо)
        /// </summary>
        [DataMember]
        public string CheckType { get; set; }

        /// <summary>
        /// Дата и номер акта, составленного по результатам проверки, 
        /// дата его вручения представителю юридического лица, индивидуальному предпринимателю
        /// </summary>
        [DataMember]
        public string DateNumOfCheckRes { get; set; }

        /// <summary>
        /// Выявленные нарушения обязательных требований 
        /// (указываются содержание выявленного нарушения со ссылкой на положение нормативного правового акта, 
        /// которым установлено нарушенное требование, допустившее его лицо)
        /// </summary>
        [DataMember]
        public string FoundViolations { get; set; }

        /// <summary>
        /// Дата, номер и содержание выданного предписания об устранении выявленных нарушений
        /// </summary>
        [DataMember]
        public string DateNumOfContentOfElimination { get; set; }

        /// <summary>
        /// Фамилия, имя, отчество (в случае, если имеется), должность должностного лица (должностных лиц), проводящего(их) проверку
        /// </summary>
        [DataMember]
        public string CheckerPersonInfo { get; set; }
    }
}
