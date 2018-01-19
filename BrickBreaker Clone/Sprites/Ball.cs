using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace BrickBreaker_Clone.Sprites
{
    class Ball : Sprite
    {

        public Vector2? startingPosition = null;
        
         

        public Ball(Texture2D texture, int width, int height) 
            : base(texture, width,height)
        {

        }

        public override void Update(GameTime gameTime, List<Sprite> sprites)
        {
                
        }
    }
}
