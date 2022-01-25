using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;

namespace GameProject0
{
    
    public class AnimatedSprite
    {
        private double animationTimer;

        private short animationFrame = 1;
        private short animationDirection = 1;

        public void Draw(GameTime gametime, SpriteBatch spriteBatch, Texture2D texture, Vector2 position)
        {
            //update time
            animationTimer += gametime.ElapsedGameTime.TotalSeconds;

            //update frame
            if (animationTimer > .3)
            {
                
                if (animationFrame >= 3) animationDirection = -1;
                if (animationFrame <= 1) animationDirection = 1;

                animationFrame += animationDirection;
                
                animationTimer -= .3;
            }
            //draw the sprite
            var source = new Rectangle(animationFrame * 16 + 320, 80, 16, 16);
            spriteBatch.Draw(texture, position, source, Color.White, 0f, new Vector2(0,0), (float)5, SpriteEffects.None,0);
        }
    }
}
