﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using RHOKSAutomationConsole.EFRHOKS2020;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading;
using System.Threading.Tasks;

namespace RHOKSAutomationConsole.EFRHOKS2020
{
    public partial class RHOKS_2020Context
    {
        private IRHOKS_2020ContextProcedures _procedures;

        public virtual IRHOKS_2020ContextProcedures Procedures
        {
            get
            {
                if (_procedures is null) _procedures = new RHOKS_2020ContextProcedures(this);
                return _procedures;
            }
            set
            {
                _procedures = value;
            }
        }

        public IRHOKS_2020ContextProcedures GetProcedures()
        {
            return Procedures;
        }
    }

    public partial class RHOKS_2020ContextProcedures : IRHOKS_2020ContextProcedures
    {
        private readonly RHOKS_2020Context _context;

        public RHOKS_2020ContextProcedures(RHOKS_2020Context context)
        {
            _context = context;
        }

        public virtual async Task<int> AC_SamplePhotos_RHOKS_2020Async(OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default)
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
            var _ = await _context.Database.ExecuteSqlRawAsync("EXEC @returnValue = [Admin].[AC_SamplePhotos_RHOKS_2020]", sqlParameters, cancellationToken);

            returnValue?.SetValue(parameterreturnValue.Value);

            return _;
        }

        public virtual async Task<List<SP_0100_ACQDespatchSendPivotResult>> SP_0100_ACQDespatchSendPivotAsync(OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default)
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
            var _ = await _context.SqlQueryAsync<SP_0100_ACQDespatchSendPivotResult>("EXEC @returnValue = [Admin].[SP_0100_ACQDespatchSendPivot]", sqlParameters, cancellationToken);

            returnValue?.SetValue(parameterreturnValue.Value);

            return _;
        }

        public virtual async Task<List<SP_0110_ACQDespatchReturnPivotResult>> SP_0110_ACQDespatchReturnPivotAsync(OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default)
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
            var _ = await _context.SqlQueryAsync<SP_0110_ACQDespatchReturnPivotResult>("EXEC @returnValue = [Admin].[SP_0110_ACQDespatchReturnPivot]", sqlParameters, cancellationToken);

            returnValue?.SetValue(parameterreturnValue.Value);

            return _;
        }

        public virtual async Task<int> SP_DynamicMerge_Q2Async(string CATALOG_IN, string SCHEMA_IN, string TARGET_IN, string SOURCE_IN, string DynamicTable, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default)
        {
            var parameterreturnValue = new SqlParameter
            {
                ParameterName = "returnValue",
                Direction = System.Data.ParameterDirection.Output,
                SqlDbType = System.Data.SqlDbType.Int,
            };

            var sqlParameters = new []
            {
                new SqlParameter
                {
                    ParameterName = "CATALOG_IN",
                    Size = 960,
                    Value = CATALOG_IN ?? Convert.DBNull,
                    SqlDbType = System.Data.SqlDbType.NVarChar,
                },
                new SqlParameter
                {
                    ParameterName = "SCHEMA_IN",
                    Size = 960,
                    Value = SCHEMA_IN ?? Convert.DBNull,
                    SqlDbType = System.Data.SqlDbType.NVarChar,
                },
                new SqlParameter
                {
                    ParameterName = "TARGET_IN",
                    Size = 960,
                    Value = TARGET_IN ?? Convert.DBNull,
                    SqlDbType = System.Data.SqlDbType.NVarChar,
                },
                new SqlParameter
                {
                    ParameterName = "SOURCE_IN",
                    Size = -1,
                    Value = SOURCE_IN ?? Convert.DBNull,
                    SqlDbType = System.Data.SqlDbType.NVarChar,
                },
                new SqlParameter
                {
                    ParameterName = "DynamicTable",
                    Size = 400,
                    Value = DynamicTable ?? Convert.DBNull,
                    SqlDbType = System.Data.SqlDbType.NVarChar,
                },
                parameterreturnValue,
            };
            var _ = await _context.Database.ExecuteSqlRawAsync("EXEC @returnValue = [Admin].[SP_DynamicMerge_Q2] @CATALOG_IN = @CATALOG_IN, @SCHEMA_IN = @SCHEMA_IN, @TARGET_IN = @TARGET_IN, @SOURCE_IN = @SOURCE_IN, @DynamicTable = @DynamicTable", sqlParameters, cancellationToken);

            returnValue?.SetValue(parameterreturnValue.Value);

            return _;
        }

        public virtual async Task<List<SP_MergeACQDepthsResult>> SP_MergeACQDepthsAsync(OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default)
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
            var _ = await _context.SqlQueryAsync<SP_MergeACQDepthsResult>("EXEC @returnValue = [dbo].[SP_MergeACQDepths]", sqlParameters, cancellationToken);

            returnValue?.SetValue(parameterreturnValue.Value);

            return _;
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

        public virtual async Task<List<SP_UPDATE_DOWNHOLE_LAS_HEADERResult>> SP_UPDATE_DOWNHOLE_LAS_HEADERAsync(OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default)
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
            var _ = await _context.SqlQueryAsync<SP_UPDATE_DOWNHOLE_LAS_HEADERResult>("EXEC @returnValue = [dbo].[SP_UPDATE_DOWNHOLE_LAS_HEADER]", sqlParameters, cancellationToken);

            returnValue?.SetValue(parameterreturnValue.Value);

            return _;
        }
    }
}