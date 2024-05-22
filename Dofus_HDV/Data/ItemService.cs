using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Dofus_HDV.Data;

public class ItemService
{
    private readonly ApplicationDbContext _context;

    public ItemService(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<List<Item>> GetItemsAsync()
    {
        return await _context.Items.ToListAsync();
    }
}
