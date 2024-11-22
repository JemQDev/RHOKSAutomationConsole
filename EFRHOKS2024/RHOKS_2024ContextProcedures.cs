﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using RHOKSAutomationConsole.EFRHOKS2024;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading;
using System.Threading.Tasks;

namespace RHOKSAutomationConsole.EFRHOKS2024
{
    public partial class RHOKS_2024Context
    {
        private IRHOKS_2024ContextProcedures _procedures;

        public virtual IRHOKS_2024ContextProcedures Procedures
        {
            get
            {
                if (_procedures is null) _procedures = new RHOKS_2024ContextProcedures(this);
                return _procedures;
            }
            set
            {
                _procedures = value;
            }
        }

        public IRHOKS_2024ContextProcedures GetProcedures()
        {
            return Procedures;
        }
    }

    public partial class RHOKS_2024ContextProcedures : IRHOKS_2024ContextProcedures
    {
        private readonly RHOKS_2024Context _context;

        public RHOKS_2024ContextProcedures(RHOKS_2024Context context)
        {
            _context = context;
        }

        public virtual async Task<int> SP_Update_ACQ_DRILLHOLES_TableAsync(OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default)
        {
            var parameterreturnValue = new SqlParameter
            {
                ParameterName = "returnValue",
                Direction = System.Data.ParameterDirection.Output,
                SqlDbType = System.Data.SqlDbType.Int,
            };

            var sqlParameters = new []
            {
                parameterreturnValue,
            };
            var _ = await _context.Database.ExecuteSqlRawAsync("EXEC @returnValue = [Admin].[SP_Update_ACQ_DRILLHOLES_Table]", sqlParameters, cancellationToken);

            returnValue?.SetValue(parameterreturnValue.Value);

            return _;
        }
    }
}
