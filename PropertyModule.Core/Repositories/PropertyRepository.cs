using Common;
using PropertyModule.Core.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PropertyModule.Core.Repositories
{
    // Note: What is the class lifetime
    public class PropertyRepository : IGenericRepo<PropertyEntity>
    {
        private readonly IToolSet<PropertyEntity> _toolSet;
        public PropertyRepository(IToolSet<PropertyEntity> toolSet)
        {
            _toolSet = toolSet;
        }
        public async Task<List<PropertyEntity>> GetAll()
        {
            return await _toolSet.MeasureExecutionTimeAsync(async () =>
            {
                var properties = new List<PropertyEntity>();
                for (int i = 1; i <= 20; i++)
                {
                    await Task.Delay(2);
                    properties.Add(new ($"Property {i}",$"pic{i%2}.png"));
                }
                return properties;
            });
        }
    }
}
