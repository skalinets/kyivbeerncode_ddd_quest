# Subject

Модель событий BeerNCode.

1. Реестр событий. Событие можно регистрировать
2. На событие может зарегистрироваться посетитель

Рекваирменты

1. Событие может иметь ограничение на количество посетителей
2. Посетитель может регистрироваться один раз
3. Регистрация события - привелегированная операция

# Domain Model

	Meeting - RA

		Address - VO
		Date
		MaxNumberOfAttendies
		Attendies

# Implementation

	Tests - **NUnit**, MSpec, Cucumber
	Persitence - **NHibernate**, Memory, MongoDb
	UI - **Console**, ASP.NET MVC, REST Like API

# UI

1. Список событий, регистрация события
2. Список посетителей, регистрация посетителя.

# Tricks

# Source Code

1. Visual Studio 2010
2. NUnit Tests (either notthing special, could be easy changed to something else)

Note#1: We do not check-in dependencies from nuget to source control. This is OK. When you will build solution for first time, script will automatically dowload everything it needs.

Note#2: To build solution run `msbuild` in solution folder. It will peak default solution file and build.