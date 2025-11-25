using EmployeePortal.Models;
using System.ComponentModel.DataAnnotations;

namespace EmployeePortal.ViewModels
{
    public class EmployeeCreateUpdateViewModel
    {
        public int? Id { get; set; }

        [Display(Name = "Полное имя")]
        [Required(ErrorMessage = "Полное имя обязательно")]
        [StringLength(100)]
        public string FullName { get; set; } = null!;

        [Required(ErrorMessage = "Email обязателен")]
        [EmailAddress(ErrorMessage = "Неверный формат Email адреса")]
        public string Email { get; set; } = null!;

        [Display(Name = "Отдел")]
        [Required(ErrorMessage = "Отдел обязателен")]
        public int DepartmentId { get; set; }

        [Display(Name = "Должность")]
        [Required(ErrorMessage = "Должность обязательна")]
        public int DesignationId { get; set; }

        [Display(Name = "Дата приема на работу")]
        [Required(ErrorMessage = "Дата приема на работу обязательна")]
        [DataType(DataType.Date)]
        [CustomValidation(typeof(EmployeeCreateUpdateViewModel), nameof(ValidateHireDate))]
        public DateTime HireDate { get; set; } = DateTime.Today;

        [Display(Name = "Дата рождения")]
        [Required(ErrorMessage = "Дата рождения обязательна")]
        [DataType(DataType.Date)]
        [CustomValidation(typeof(EmployeeCreateUpdateViewModel), nameof(ValidateDateOfBirth))]
        public DateTime DateOfBirth { get; set; } = DateTime.Today.AddYears(-60);

        [Display(Name = "Тип сотрудника")]
        [Required(ErrorMessage = "Тип сотрудника обязателен")]
        public int EmployeeTypeId { get; set; }

        [Required(ErrorMessage = "Пол обязателен")]
        public string Gender { get; set; } = null!;

        [Required(ErrorMessage = "Зарплата обязательна")]
        [Range(0, double.MaxValue, ErrorMessage = "Зарплата должна быть положительным числом")]
        public decimal Salary { get; set; }

        // For dropdown lists
        public List<Department>? Departments { get; set; }
        public List<Designation>? Designations { get; set; }
        public List<EmployeeType>? EmployeeTypes { get; set; }

        // Validation methods:
        public static ValidationResult? ValidateHireDate(DateTime? hireDate, ValidationContext context)
        {
            if (!hireDate.HasValue)
                return new ValidationResult("Дата приема на работу обязательна.");

            if (hireDate.Value.Date > DateTime.Today)
                return new ValidationResult("Дата приема на работу не может быть в будущем.");

            return ValidationResult.Success;
        }

        public static ValidationResult? ValidateDateOfBirth(DateTime? dob, ValidationContext context)
        {
            if (!dob.HasValue)
                return new ValidationResult("Дата рождения обязательна.");

            var minDob = DateTime.Today.AddYears(-60);  
            var maxDob = DateTime.Today.AddYears(-18);  

            if (dob.Value.Date < minDob || dob.Value.Date > maxDob)
                return new ValidationResult($"Дата рождения должна быть между {minDob:dd.MM.yyyy} и {maxDob:dd.MM.yyyy}.");

            return ValidationResult.Success;
        }
    }
}
