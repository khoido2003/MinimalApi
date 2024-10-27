using Microsoft.EntityFrameworkCore;
using MinimalAPI.Models;

namespace MinimalAPI.Data
{
  public class CommandRepo : ICommandRepo
  {
    private readonly AppDbContext _context;

    public CommandRepo(AppDbContext context)
    {
      _context = context;
    }

    async Task ICommandRepo.CreateCommand(Command command)
    {
      if (command == null)
      {
        throw new ArgumentNullException(nameof(command));
      }
      await _context.AddAsync(command);

    }

    void ICommandRepo.DeleteCommand(Command command)
    {
      if (command == null)
      {
        throw new ArgumentNullException(nameof(command));
      }
      _context.Commands.Remove(command);
    }

    async Task<IEnumerable<Command>> ICommandRepo.GetAllCommands()
    {
      return await _context.Commands.ToListAsync();
    }

    async Task<Command?> ICommandRepo.GetCommandById(int id)
    {
      return await _context.Commands.FirstOrDefaultAsync(c => c.Id == id);

    }

    async Task ICommandRepo.SaveChanges()
    {
      await _context.SaveChangesAsync();
    }
  }
}