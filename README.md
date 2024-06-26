# Recipes Project

![appscreenshot](https://github.com/tkqa1ex/project-recipes/blob/main/screenshot.png)

## Описание
Проектът "Recipes" е приложение за управление на рецепти, което позволява на потребителите да добавят, редактират, изтриват и преглеждат рецепти. Това е Windows Forms приложение, създадено с използването на C# програмен език и Entity Framework Core за работа с база данни.

## Компоненти на проекта
Проектът се състои от няколко основни компонента:

1. **RecipesForm**: Това е основната форма на приложението, където потребителите могат да въвеждат, редактират и изтриват рецепти. Също така тук се показват списъкът с налични рецепти и подробна информация за избраната рецепта.

2. **RecipesController**: Класът RecipesController управлява логиката за обработка на данни и взаимодействие с базата данни. Той предоставя методи за добавяне, редактиране, изтриване и търсене на рецепти.

3. **RecipesDbContext**: Класът RecipesDbContext служи за свързване с базата данни и дефинира модела на данните за рецептите.

4. **Recipe**: Класът Recipe представлява модел на единична рецепта, който включва свойства като име на рецептата, съставки и инструкции за приготвяне.

## Функционалности
Проектът "Recipes" предоставя следните функционалности:

- **Добавяне на рецепти**: Потребителите могат да добавят нови рецепти, като въвеждат име на рецептата, съставки и инструкции за приготвяне.

- **Редактиране на рецепти**: Потребителите могат да редактират съществуващи рецепти, като променят името на рецептата, съставките и инструкциите за приготвяне.

- **Изтриване на рецепти**: Потребителите могат да изтриват съществуващи рецепти от списъка с рецепти.

- **Преглеждане на рецепти**: Потребителите могат да преглеждат списък с всички налични рецепти и да видят подробна информация за всяка една рецепта.

## Инструкции за използване
1. Стартиране на приложението: За да стартирате приложението, изпълнете RecipesForm.cs.

2. Добавяне на рецепта: За да добавите нова рецепта, въведете име на рецептата, съставки и инструкции за приготвяне в съответните текстови полета и натиснете бутона "Add".

3. Редактиране на рецепта: Изберете рецепта от списъка с рецепти, променете желаните полета за редактиране и натиснете бутона "Save".

4. Изтриване на рецепта: Изберете рецепта от списъка с рецепти и натиснете бутона "Delete".

5. Преглеждане на рецепти: В списъка с рецепти можете да видите всички налични рецепти. Изберете рецепта, за да видите подробна информация за нея в съответните текстови полета.

## Изисквания
- .NET Framework 4.7.2 или по-нов
- Microsoft.EntityFrameworkCore версия 5.0 или по-нов
- Microsoft.EntityFrameworkCore.Sqlite версия 5.0 или по-нов

## Заключение
Проектът "Recipes" предоставя удобен начин за управление на рецепти през едно Windows Forms приложение. Със своите функционалности за добавяне, редактиране, изтриване и преглеждане на рецепти, приложението прави управлението на кулинарни рецепти лесно и ефективно.
