using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace GameProject0
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        private AnimatedSprite[] _animatedSprites;
        private Texture2D _spriteSheet;
        private SpriteFont _bangers;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            _animatedSprites = new AnimatedSprite[]
            {
                new AnimatedSprite(),
                new AnimatedSprite()
            };
            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here
            _spriteSheet = Content.Load<Texture2D>("colored_packed");
            _bangers = Content.Load<SpriteFont>("bangers");
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here
            _spriteBatch.Begin();
            _animatedSprites[0].Draw(gameTime, _spriteBatch, _spriteSheet, new Vector2(25, 400));
            _animatedSprites[1].Draw(gameTime, _spriteBatch, _spriteSheet, new Vector2(700, 400));
            _spriteBatch.Draw(_spriteSheet, new Vector2(0,0), new Rectangle(96, 16, 16, 16), Color.White, 0f, new Vector2(0, 0), (float)5, SpriteEffects.None, 0);
            _spriteBatch.Draw(_spriteSheet, new Vector2(GraphicsDevice.Viewport.Width - 80, 0), new Rectangle(96, 16, 16, 16), Color.White, 0f, new Vector2(0, 0), (float)5, SpriteEffects.None, 0);
            _spriteBatch.DrawString(_bangers, "Springy Cactus", new Vector2(GraphicsDevice.Viewport.Width / 2 - 145, GraphicsDevice.Viewport.Height / 2), Color.Goldenrod);
            _spriteBatch.DrawString(_bangers, "Press esc or B to exit.", new Vector2(GraphicsDevice.Viewport.Width / 2 - 185, GraphicsDevice.Viewport.Height - 45), Color.Black);
            _spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}
