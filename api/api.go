package api

import (
	"github.com/gofiber/fiber/v2"
	"github.com/gofiber/fiber/v2/middleware/logger"
)

func Start() error {
	// engine := html.New("./views", ".html")

	app := fiber.New(fiber.Config{
		//	Views:         engine,
		CaseSensitive: true,
	})

	app.Use(logger.New())

	app.Static("/", "./static")

	for _, r := range routes {
		app.Get(r.Url, r.Callback)
	}

	return app.Listen(":3000")
}
