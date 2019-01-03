using AutoMapper;
using Common;
using DAL.Dtos;
using DAL.IRepositories;
using DAL.Model;
using DAL.Pagination;
using FluentValidation;
using IBLL;
using JiChuKu.Common;
using JiChuKu.Models;
using JiChuKu.Models.PropertyMappings;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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

        private readonly IEnhancedRepository<FLegalPerson> _vehicleRepository;
        public FLegalPersonController(IValidator<FLegalPersonTest> validator, IMapper mapper, IHttpContextAccessor accessor, IFLegalPersonRepository fLegalPerson, IEnhancedRepository<FLegalPerson> vehicleRepository)
        {
            _validator = validator;
            _mapper = mapper;
            _accessor = accessor;
            _fLegalPerson = fLegalPerson;
            _vehicleRepository = vehicleRepository;
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
        public async Task<IActionResult> GetFLegalPerson(string id)
        {
            if (string.IsNullOrWhiteSpace(id))
            {
                return NotFound(ReturnStd.Error("id不能为空！"));
            }
            // var product = _fLegalPerson.GetById(id, includeData);
            var item = await _vehicleRepository.GetByIdAsync(id);
            if (item == null)
            {
                return NotFound(ReturnStd.Error(string.Format("没有查询到 {0} 数据！", id)));
            }
            //var fLegalPersonDto = _mapper.Map<FLegalPersonDto>(product);
            return Ok(ReturnStd.Success(item));
        }

        [HttpPost("GetFlegalPersonAll")]
        public async Task<IActionResult> GetFLegalPersonAll([FromBody]QueryViewModel parameters)
        {
            var propertyMapping = new FLegalPersonPropertyMapping();
            PaginatedList<FLegalPerson> pagedList;
            if (string.IsNullOrEmpty(parameters.SearchTerm))
            {
                pagedList = await _vehicleRepository.GetPaginatedAsync(parameters, propertyMapping);
            }
            else
            {
                pagedList = await _vehicleRepository.GetPaginatedAsync(parameters, propertyMapping,
                    x => x.Id.Contains(parameters.SearchTerm) || x.FCreditCode.Contains(parameters.SearchTerm));
            }
           // var vehicleVms = Mapper.Map<IEnumerable<FLegalPersonTest>>(pagedList);

            return Ok(pagedList);
        }

        [HttpDelete]
        public IActionResult DeleteFLegalPerson(string id)
        {
            if (string.IsNullOrWhiteSpace(id))
            {
                return NotFound(ReturnStd.Error("id不能为空！"));
            }
            int product = _fLegalPerson.Delete(id);
            if (product < 0)
            {
                return NotFound(ReturnStd.Error(string.Format("没有查询到 {0} 数据！", id)));
            }
            return Ok(ReturnStd.Success(Suggestion.DeleteSucceed));
        }
    }
}