package main

import "HarryPotterAPI/api"

func main() {
	if err := api.Start(); err != nil {
		panic(err)
	}
}
