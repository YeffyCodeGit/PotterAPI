package api

import "io/ioutil"

func GetData(item string) (string, error) {
	dat, err := ioutil.ReadFile("./data/" + item + ".json")

	if err != nil {
		return "", err
	}

	return string(dat), nil
}
