using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using FluentValidation.Models;
using FluentValidation.Validator;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FluentValidation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {

        //IValidator is an interface that represents a validator capable of validating 
        private readonly IValidator<Person> _validator;

        //dependecy injection
        public PersonController(IValidator<Person> validator)
        {
            _validator = validator;

        }
        [HttpPost]
        public IActionResult Post([FromBody] Person person)
        {
            // represents the result of a validation operation, containing information about whether the validation was successful or not.
            var validationResult = _validator.Validate(person);

            if (!validationResult.IsValid)
            {
                return BadRequest(validationResult.Errors);
            }

            return StatusCode(StatusCodes.Status200OK, person);

        }


    }

}