using AdminTarefas.Application.DTOs;
using AdminTarefas.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace AdminTarefas.WebUI.Controllers
{
    public class AssignmentController : Controller
    {
        private readonly IAssignmentService _assignmentService;
        public AssignmentController(IAssignmentService assignmentService)
        {
            _assignmentService = assignmentService;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var assignmentsDto  = await _assignmentService.GetAssignmentAsync();
            return View(assignmentsDto);
        }

        //[HttpGet]
        //public async Task<IActionResult> CreateAssignment(AssignmentDTO assignmentDTO)
        //{
        //    var assignment = new AssignmentDTO();
        //    assignment = await _assignmentService.Create(assignmentDTO);
        //    return View(assignment);

        //}
    }
}
