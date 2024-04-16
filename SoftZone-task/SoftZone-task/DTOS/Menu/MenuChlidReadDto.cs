using SoftZone_task.DTOS.Item;

namespace SoftZone_task.DTOS.Menu
{
    public record MenuChlidReadDto
    {
        public int MenuId { get; set; }
        public List<ItemChildReadDTO> Items { get; init; }

    }
}
