# Pl2D
All

Файл .gitignore: https://github.com/github/gitignore/b...
Чья-то инструкция по настройке ключей: https://habr.com/ru/post/217869/
Клиент, который я использую: https://tortoisegit.org/

Get started by creating a new file or uploading an existing file. We recommend every repository include a README, LICENSE, and .gitignore.
Начните работу, создав новый файл или загрузив существующий. Мы рекомендуем, чтобы каждый репозиторий включал README, LICENSE и .gitignore.

…or create a new repository on the command line
... или создать новое хранилище в командной строке.

echo "# Pl2D" >> README.md
git init // создать ветку (master)
git add README.md
git commit -m "first commit"
git branch -M main // (master) переименовать в (main)
git remote add origin https://github.com/Entrol25/Pl2D.git
                SSH   git@github.com:Entrol25/Pl2D.git
git push -u origin main

…or push an existing repository from the command line
...или подтолкнуть существующий репозиторий из командной строки.

git remote add origin https://github.com/Entrol25/Pl2D.git
                SSH   git@github.com:Entrol25/Pl2D.git
git branch -M main // (master) переименовать в (main)
git push -u origin main