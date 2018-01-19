using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;


namespace BrickBreaker_Clone.Sprites
{
    public class Sprite
    {
        protected Texture2D _texture;
        public Vector2 position;
        public Vector2 velocity;
        public float speed;
        public Rectangle rectangle;
        public int _height, _width;
        public int rotation;
        


        public Sprite(Texture2D texture, int width, int height)
        {
            _texture = texture;
            _width = width;
            _height = height;
            rectangle = new Rectangle(new Point((int)position.X,(int)position.Y), new Point(width,height));
        }

        public virtual void Update(GameTime gameTime, List<Sprite> sprites)
        {

        }

        public virtual void Draw(SpriteBatch sp)
        {
            sp.Draw(_texture, destinationRectangle: rectangle, 
                origin: new Vector2(_width/2,_height/2),
                rotation: rotation);
            
        }

        #region Collision
        public float top
        {
            get
            {
                return position.Y - (_height / 2);
            }
            set
            {
                position.Y = value + (_height / 2);
            }
        }
        public float bottom
        {
            get
            {
                return position.Y + (_height / 2);
            }
            set
            {
                position.Y = value - (_height / 2);
            }
        }
        public float left
        {
            get
            {
                return position.X - (_width / 2);
            }
            set
            {
                position.X = value + (_width / 2);
            }
        }
        public float right
        {
            get
            {
                return position.X + (_width / 2);
            }
            set
            {
                position.X = value - (_width / 2);
            }
        }

        public bool OverlapsWith(Sprite sprite)
        {
            if ((sprite.right > this.left) && (sprite.left < this.right)
                || (sprite.top < this.bottom) && (sprite.bottom > this.top))
            {

                return true;

            }
            else
            {
                return false;
            }

        }
        #endregion


    }
}
