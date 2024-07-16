using EXAMEN_APIREST.Data;
using EXAMEN_APIREST.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EXAMEN_APIREST.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly EmployeeContext _context;
        public EmployeesController(EmployeeContext context)
        {
            _context = context;
        }

        // GET: api/employees
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Employee>>> GetEmployees()
        {
            return await _context.Employees.ToListAsync();
        }

        // GET: api/employees/{id}
        [HttpGet("{id}")]
        public async Task<ActionResult<Employee>> GetEmployee(int id)
        {
            var employee = await _context.Employees.FindAsync(id);

            if (employee == null)
            {
                return NotFound(new { message = "El id ingresado no existe." });
            }

            return employee;
        }

        // GET: api/employees/document/{documentNumber}
        [HttpGet("document/{documentNumber}")]
        public async Task<ActionResult<Employee>> GetEmployeeByDocumentNumber(string documentNumber)
        {
            if (documentNumber.Length > 8)
            {
                return NotFound(new { message = "El número de documento excede la longitud permitida de 8 dígitos." });
            }

            var employee = await _context.Employees
                .FirstOrDefaultAsync(e => e.Document_Number == documentNumber);

            if (employee == null)
            {
                return NotFound(new { message = "El número de documento ingresado no existe." });
            }

            return employee;
        }

        // POST: api/employees
        [HttpPost]
        public async Task<ActionResult<Employee>> PostEmployee(Employee employee)
        {
            _context.Employees.Add(employee);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetEmployee), new { id = employee.Id }, employee);
        }

        [HttpPut]
        public async Task<ActionResult<Employee>> PutEmployee(Employee employee)
        {
            var employeeDb = await _context.Employees.FindAsync(employee.Id);

            if (employeeDb == null)
            {
                return NotFound(new { message = "El employee ingresado no existe." });
            }

            employeeDb.Name = employee.Name;
            employeeDb.Document_Number = employee.Document_Number;
            employeeDb.Salary = employee.Salary;
            employeeDb.Age = employee.Age;
            employeeDb.Profile = employee.Profile;
            employeeDb.Admission_Date = employee.Admission_Date;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                
                return NotFound(new { message = ex.Message });
                
            }

            return employeeDb;
        }

        // DELETE: api/employees/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEmployee(int id)
        {
            var employee = await _context.Employees.FindAsync(id);
            if (employee == null)
            {
                return NotFound(new { message = "El id de employee ingresado no existe." });
            }

            _context.Employees.Remove(employee);
            await _context.SaveChangesAsync();

            return Ok(new { message = "El employee se elimino correctamente." });
        }


    }
}
