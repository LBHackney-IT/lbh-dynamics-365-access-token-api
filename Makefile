.PHONY: setup
setup:
	docker-compose build

.PHONY: build
build:
	docker-compose build lbh-dynamics365-accesstoken-api

.PHONY: serve
serve:
	docker-compose build lbh-dynamics365-accesstoken-api && docker-compose up lbh-dynamics365-accesstoken-api

.PHONY: shell
shell:
	docker-compose run lbh-dynamics365-accesstoken-api bash

.PHONY: test
test:
	docker-compose up -d test-database
	docker-compose build lbh-dynamics365-accesstoken-api-test && docker-compose up lbh-dynamics365-accesstoken-api-test

.PHONY: lint
lint:
	-dotnet tool install -g dotnet-format
	dotnet tool update -g dotnet-format
	dotnet format
