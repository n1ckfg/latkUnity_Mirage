@echo off

git submodule init
git submodule update
git submodule sync
git submodule foreach git checkout master
git submodule foreach git reset --hard
git submodule foreach git pull origin master

cd Assets\latkxGDrive
git checkout unity-2018-lts

@pause