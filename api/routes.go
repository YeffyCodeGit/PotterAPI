package api

import (
	"github.com/gofiber/fiber/v2"
)

type Route struct {
	Url      string
	Callback func(c *fiber.Ctx) error
}

var routes = []Route{
	{
		Url: "/books",
		Callback: func(c *fiber.Ctx) error {
			book, err := GetData("books")

			if err != nil {
				return c.SendStatus(500)
			}

			return c.SendString(book)
		},
	},
	{
		Url: "/houses",
		Callback: func(c *fiber.Ctx) error {
			houses, err := GetData("houses")

			if err != nil {
				return c.SendStatus(500)
			}

			return c.SendString(houses)
		},
	},
	{
		Url: "/horcruxes",
		Callback: func(c *fiber.Ctx) error {
			horcruxes, err := GetData("horcruxes")

			if err != nil {
				return c.SendStatus(500)
			}

			return c.SendString(horcruxes)
		},
	},
	{
		Url: "/schools",
		Callback: func(c *fiber.Ctx) error {
			schools, err := GetData("schools")

			if err != nil {
				return c.SendStatus(500)
			}

			return c.SendString(schools)
		},
	},
	{
		Url: "/subjects",
		Callback: func(c *fiber.Ctx) error {
			subjects, err := GetData("subjects")

			if err != nil {
				return c.SendStatus(500)
			}

			return c.SendString(subjects)
		},
	},
	{
		Url: "/characters",
		Callback: func(c *fiber.Ctx) error {
			characters, err := GetData("characters")

			if err != nil {
				return c.SendStatus(500)
			}

			return c.SendString(characters)
		},
	},
	{
		Url: "/spells",
		Callback: func(c *fiber.Ctx) error {
			spells, err := GetData("spells")

			if err != nil {
				return c.SendStatus(500)
			}

			return c.SendString(spells)
		},
	},
}
