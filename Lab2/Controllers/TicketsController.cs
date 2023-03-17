using Lab2.Models.Domain;
using Lab2.Models.View;
using Microsoft.AspNetCore.Mvc;


namespace Lab2.Controllers;

public class TicketsController : Controller
{
    private readonly ILogger<TicketsController> _logger;


    public TicketsController(ILogger<TicketsController> logger)
    {
        _logger = logger;
    }
    public IActionResult Index()
    {
        var tickets = Ticket.GetTicketsList();
        return View(tickets);
    }
    #region constrains
    //Tickets/Get
    // [Route("/Tickets/Get/{ticketId:guid}")]
    //public IActionResult Get(Guid ticketId)
    //{
    //    _logger.LogInformation(ticketId.ToString());
    //    var tickets = Ticket.GetTicketsList().Where(t => t.Id == ticketId).ToList();
    //    return View("Index", tickets);
    //}
    //// [Route("/Tickets/Get/{title}")]
    // public IActionResult Get(string title)
    // {
    //     _logger.LogInformation(title.ToString());
    //     var tickets = Ticket.GetTicketsList().Where(t => t.Title.Contains(title)).ToList();
    //     return View("Index", tickets);
    // }
    #endregion
    public IActionResult Get(Ticket newTicket)
    {
        _logger.LogInformation(newTicket.ToString());
        Ticket.GetTicketsList().Add(newTicket);
        return View("Index", null);
    }
    [HttpGet]
    public IActionResult GetAddedForm()
    {
        return View();
    }
    [HttpPost]
    public IActionResult AddTicket(AddTicketVM ticketVM)
    {
        var ticketsList = Ticket.GetTicketsList();
        var addNewTicket = new Ticket
        {
            Id = Guid.NewGuid(),
            Title = ticketVM.title,
            Price = ticketVM.price
        };
        ticketsList.Add(addNewTicket);
        return RedirectToAction(nameof(Index));
    }
}

