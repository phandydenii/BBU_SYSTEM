using System;
using AutoMapper;
using BBU_SYSTEM.Respository;
using Microsoft.EntityFrameworkCore;

namespace BBU_SYSTEM.Service
{
	public class FieldCertificateService : IFieldCertificate
	{
        private readonly ICampusDbContext _campusDbContext;
        private readonly IMapper _mapper;
        public FieldCertificateService(ICampusDbContext campusDbContext, IMapper mapper)
        {
            this._campusDbContext = campusDbContext;
            this._mapper = mapper;
        }
        public async Task<IEnumerable<FieldCertificate>> get(string campus)
        {
            var data =await _campusDbContext.DbContext(campus).tbl_field_certificate.ToListAsync();
            return data!;
        }
    }
}

