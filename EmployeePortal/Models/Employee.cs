using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeePortal.Models
{
    public class Employee
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Полное имя обязательно")]
        [StringLength(100, ErrorMessage = "Полное имя не может быть длиннее 100 символов")]
        public string FullName { get; set; } = null!;

        [Required(ErrorMessage = "Email обязателен")]
        [EmailAddress(ErrorMessage = "Неверный формат Email адреса")]
        public string Email { get; set; } = null!;

        [Required(ErrorMessage = "Отдел обязателен")]
        public int DepartmentId { get; set; }
        public Department Department { get; set; } = null!;

        [Required(ErrorMessage = "Должность обязательна")]
        public int DesignationId { get; set; }
        public Designation Designation { get; set; } = null!;

        [Required(ErrorMessage = "Дата приема на работу обязательна")]
        [DataType(DataType.Date)]
        public DateTime HireDate { get; set; }

        [Required(ErrorMessage = "Дата рождения обязательна")]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }

        [Required(ErrorMessage = "Тип сотрудника обязателен")]
        public int EmployeeTypeId { get; set; }
        public EmployeeType EmployeeType { get; set; } = null!;

        [Required(ErrorMessage = "Пол обязателен")]
        [StringLength(10, ErrorMessage = "Пол должен быть: Мужской, Женский или Другой")]
        public string Gender { get; set; } = null!;

        [Required(ErrorMessage = "Зарплата обязательна")]
        [Range(0, double.MaxValue, ErrorMessage = "Зарплата должна быть положительным числом")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Salary { get; set; }
    }
}
