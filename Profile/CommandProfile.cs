using MinimalAPI.DTOs;
using MinimalAPI.Models;

namespace MinimalAPI.Profile
{
  public class CommandProfile : AutoMapper.Profile
  {
    public CommandProfile()
    {
      CreateMap<Command, CommandReadDto>();
      CreateMap<CommandCreateDTO, Command>();
      CreateMap<CommandUpdateDTO, Command>();

    }
  }
}