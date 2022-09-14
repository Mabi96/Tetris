using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tetris.Blocks;

namespace Tetris
{
    //Class is responsible for picking next block in the game
    public class BlockQueue
    {
        private readonly Block[] blocks = new Block[]
        {
            new IBlock(),
            new JBlock(),
            new LBlock(),
            new OBlock(),
            new SBlock(),
            new TBlock(),
            new ZBlock()
        };

        private readonly Random random = new Random();
        public Block NextBlock { get; private set; }

        //Initialization of a random block
        public BlockQueue()
        {
            NextBlock = RandomBlock();
        }

        //Method which pick random block from blocks array
        private Block RandomBlock()
        {
            return blocks[random.Next(blocks.Length)];
        }


        //Returns the NextBlock and update the property
        public Block GetAndUpdae()
        {
            Block block = NextBlock;

            do
            {
                NextBlock = RandomBlock();
            } while (block.Id == NextBlock.Id);

            return block;
        }
    }
}
