using geria.ioCalculatorAssessmentTest.Data.DAL;
using geria.ioCalculatorAssessmentTest.Data.DTO;
using geria.ioCalculatorAssessmentTest.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;

namespace geria.ioCalculatorAssessmentTest.Controllers
{
    [Route("api/calculator")]
    [ApiController]
    public class CalculatorController : ControllerBase
    {
        private readonly CalculationDbContext _context;

        public CalculatorController(CalculationDbContext context)
        {
            _context = context;
        }

        [HttpPost, Authorize]
        public IActionResult PerformCalculation([FromBody] CalculationRequest request)
        {
            double result;
            switch (request.Operation)
            {
                case "+":
                    result = request.Operand1 + request.Operand2;
                    break;
                case "-":
                    result = request.Operand1 - request.Operand2;
                    break;
                case "*":
                    result = request.Operand1 * request.Operand2;
                    break;
                case "/":
                    result = request.Operand1 / request.Operand2;
                    break;
                default:
                    return BadRequest("Invalid operation");
            }

            var calculation = new CalculationModel
            {
                Operand1 = request.Operand1,
                Operation = request.Operation,
                Operand2 = request.Operand2,
                Result = result
            };

            _context.Calculations.Add(calculation);
            _context.SaveChanges();

            return Ok(calculation);
        }

        [HttpGet, Authorize]
        public IActionResult GetHistory()
        {
            var history = _context.Calculations.ToList();
            return Ok(history);
        }
    }
}
