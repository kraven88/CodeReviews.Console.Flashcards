using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kraven88.Flashcards.Models;
internal class Flashcard
{
    public int Id { get; set; }
    public int StackId { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
}
