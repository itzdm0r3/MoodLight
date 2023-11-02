using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace MoodLight
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

            //The Game World - our color values
            byte redIntensity = 0;
            bool redCountingUp = true;

            byte greenIntensity = 80;
            bool greenCountingUp = true;
        
            byte blueIntensity = 160;
            bool blueCountingUp = true;
        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;

        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here
        }

        protected override void Update(GameTime gameTime)
        {
            //Allows the game to exit
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            //Update each color in turn
            if (redIntensity == 255) redCountingUp = false;
            if (redIntensity == 0) redCountingUp = true;
            if (redCountingUp) redIntensity++; else redIntensity--;

            if (greenIntensity == 255) greenCountingUp = false;
            if (greenIntensity == 0) greenCountingUp = true;
            if (greenCountingUp) greenIntensity++; else greenIntensity--;

            if (blueIntensity == 255) blueCountingUp = false;
            if (blueIntensity == 0) blueCountingUp = true;
            if (blueCountingUp) blueIntensity++; else blueIntensity--;

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            Color backgroundColor;
            backgroundColor =
                new Color(redIntensity, greenIntensity, blueIntensity);
            _graphics.GraphicsDevice.Clear(backgroundColor);
            base.Draw(gameTime);
        }
    }
}