using System.Linq.Expressions;
using Lyceum.Domain.Entities;
using Lyceum.Domain.Models;
using Lyceum.Domain.Utils;
using Lyceum.Infrastructure.Ef;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Lyceum.Api.Controllers;

[ApiController]
[Route("api/v1/[controller]")]
public class AddCourseController : ControllerBase
{
    private readonly DataContext _dataContext;
    public AddCourseController(DataContext dataContext)
    {
        _dataContext = dataContext;
    }
    
    protected virtual IQueryable<AddCourse> FilterPredicate(Filter filter, IQueryable<AddCourse> entities)
    {
        return entities;
    }

    

    [HttpGet]
    public async Task<IActionResult> Get(int? pageIndex, int? pageSize, string? sortField, string? sortType, string? filter)
    {
        try
        {
            var config = new ListConfig(pageIndex, pageSize, sortField, sortType, filter);
            var query = _dataContext.AddCourses
                .Filter(config.Filter, FilterPredicate)
                .Sort(config.OrderFieldName, config.OrderFieldDirection);

            var items = await query.Paginate(config.PageIndex, config.PageSize).ToListAsync();
            var total = query.Count();
            var result = new ListResponse<AddCourse>(items, total);
            return Ok(result) ;
        }
        catch (Exception e)
        {
            return BadRequest(new ErrorResponse(e));
        }
    }
    
    
    [HttpGet("{id:long}")]
    public virtual async Task<IActionResult> GetById(long id)
    {
        try
        {
            var model = await _dataContext.AddCourses.SingleAsync(m => m.Id == id);
            return Ok(model);
        }
        catch (Exception e)
        {
            return BadRequest(new ErrorResponse(e));
        }
    }

    [HttpPost]
    public async Task<IActionResult> Add([FromBody] AddCourse model)
    {
        try
        {
            await _dataContext.AddCourses.AddAsync(model);
            await _dataContext.SaveChangesAsync();
            return Ok(model);
        }
        catch (Exception e)
        {
            return BadRequest(new ErrorResponse(e));
        }
    }
    
    [HttpPut]
    public async Task<IActionResult> Update([FromBody] AddCourse model)
    {
        try
        {
            _dataContext.Entry(model).State = EntityState.Modified;
            await _dataContext.SaveChangesAsync();
            return Ok(model);
        }
        catch (Exception e)
        {
            return BadRequest(new ErrorResponse(e));
        }
    }
    
    [HttpDelete("{id:long}")]
    public async Task<IActionResult> Delete(long id)
    {
        try
        {
            var model =  await _dataContext.AddCourses.SingleAsync(m => m.Id == id);
            _dataContext.AddCourses.Remove(model);
            await _dataContext.SaveChangesAsync();
            return Ok();
        }
        catch (Exception e)
        {
            return BadRequest(new ErrorResponse(e));
        }
    }
}