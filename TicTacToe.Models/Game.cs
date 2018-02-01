namespace ROAMTicTacToe.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Game
    {
        public Game()
        {
            this.Id = Guid.NewGuid();
            this.Board = "---------";
            this.State = GameState.WaitingForSecondPlayer;
        }

        [MinLength(4)][MaxLength(60)]
        public string Name { get; set; }

        [Key]
        public Guid Id { get; set; }

        [StringLength(10)]
        [Column(TypeName = "char")]
        public string Board { get; set; }

        public GameState State { get; set; }

        [Required]
        public string FirstPlayerId { get; set; }
        
        public User FirstPlayer { get; set; }

        public string SecondPlayerId { get; set; }

        public User SecondPlayer { get; set; }

        public DateTime DateCreated { get; set; }
    }
}
