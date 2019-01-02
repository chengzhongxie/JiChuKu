using AutoMapper;
using Common;
using DAL.Dtos;
using DAL.Model;
using FluentValidation;
using IBLL;
using JiChuKu.Common;
using JiChuKu.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JiChuKu.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FLegalPersonController : ControllerBase
    {
        IValidator<FLegalPersonTest> _validator;//数据校验
        private IMapper _mapper { get; set; }//类映射
        private readonly IFLegalPersonRepository _fLegalPerson;
        private IHttpContextAccessor _accessor;//获取ip
        public FLegalPersonController(IValidator<FLegalPersonTest> validator, IMapper mapper, IHttpContextAccessor accessor, IFLegalPersonRepository fLegalPerson)
        {
            _validator = validator;
            _mapper = mapper;
            _accessor = accessor;
            _fLegalPerson = fLegalPerson;
        }

        [HttpPost]
        public IActionResult Post([FromBody] FLegalPersonTest model)
        {
            // 判断实体是否为空
            if (model == null)
            {
                return BadRequest(ReturnStd.Error("数据实体不能为空！"));
            }
            // 数据校验
            var validationResult = _validator.Validate(model);
            if (!validationResult.IsValid)
            {
                return Ok(ReturnStd.Error(string.Join(";", validationResult.Errors)));
            }
            // 数据映射
            var newFLegalPerson = _mapper.Map<FLegalPerson>(model);
            if (_fLegalPerson.Create(newFLegalPerson) > 0)
            {
                return Ok(ReturnStd.Success(Suggestion.InsertSucceed));
            }
            else
            {
                return BadRequest(ReturnStd.Error("数据写入失败，请联系管理员！"));
            }
        }

        [HttpGet]
        public IActionResult GetFLegalPerson(string id, bool includeData = false)
        {
            if (string.IsNullOrWhiteSpace(id))
            {
                return NotFound(ReturnStd.Error("id不能为空！"));
            }
            var product = _fLegalPerson.GetById(id, includeData);
            if (product == null)
            {
                return NotFound(ReturnStd.Error(string.Format("没有查询到 {0} 数据！", id)));
            }
            var fLegalPersonDto = _mapper.Map<FLegalPersonDto>(product);
            return Ok(ReturnStd.Success(fLegalPersonDto));
        }

        [HttpGet("GetFlegalPersonAll")]
        public IActionResult GetFLegalPersonAll(string id, bool includeData = false)
        {
            if (string.IsNullOrWhiteSpace(id))
            {
                return NotFound(ReturnStd.Error("id不能为空！"));
            }
            var product = _fLegalPerson.GetById(id, includeData);
            if (product == null)
            {
                return NotFound(ReturnStd.Error(string.Format("没有查询到 {0} 数据！", id)));
            }
            var fLegalPersonDto = _mapper.Map<FLegalPersonDto>(product);
            return Ok(ReturnStd.Success(fLegalPersonDto));
        }
        [HttpDelete]
        public IActionResult DeleteFLegalPerson(string id)
        {
            if (string.IsNullOrWhiteSpace(id))
            {
                return NotFound(ReturnStd.Error("id不能为空！"));
            }
            int product = _fLegalPerson.Delete(id);
            if (product <0)
            {
                return NotFound(ReturnStd.Error(string.Format("没有查询到 {0} 数据！", id)));
            }          
            return Ok(ReturnStd.Success(Suggestion.DeleteSucceed));
        }
    }
}