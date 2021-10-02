package api

import (
	"github.com/gofiber/fiber/v2"
)

type Route struct {
	Url string
	Callback func(c *fiber.Ctx) error
}

var routes = []Route{
	{
		Url: "/books",
		Callback: func(c *fiber.Ctx) error {
			book, err := GetData("books")

			if err != nil { return c.SendStatus(500) }

			return c.SendString(string(book))
		},
	},
	{
		Url: "/houses",
		Callback: func(c *fiber.Ctx) error {
			houses, err := GetData("houses")

			if err != nil {
				return c.SendStatus(500)
			}

			return c.SendString(string(houses))
		},
	},
	{
		Url: "/horcruxes",
		Callback: func(c *fiber.Ctx) error {
			horcruxes, err := GetData("horcruxes")

			if err != nil { return c.SendStatus(500) }

			return c.SendString(horcruxes)
		},
	},
	{
		Url: "/schools",
		Callback: func(c *fiber.Ctx) error {
			schools, err := GetData("schools")

			if err != nil { return c.SendStatus(500) }

			return c.SendString(string(schools))
		},
	},
	{
		Url: "/subjects",
		Callback: func(c *fiber.Ctx) error {
			return c.SendString("Working on it!")
		},
	},
}