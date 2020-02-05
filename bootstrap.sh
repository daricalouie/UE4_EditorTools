#!/bin/bash

while [[ $pluginName == '' ]]
do
    read -p "provide your plugin name (do not use 'boilerplate' anywhere in your plugin name): " pluginName
done

git clone https://github.com/peetonn/UE4_BoilerplatePlugin.git $pluginName
cd $pluginName
git remote remove origin
echo "# $pluginName Plugin" > README.md
./setup.sh $pluginName
rm *.sh
git add "${pluginName}.uplugin" Source/ README.md bootstrap.sh setup.sh Boilerplate.uplugin
git commit -m"${pluginName} plugin setup"

echo ""
echo "*** $pluginName plugin setup completed."
echo "  > Add your repository now and push changes: "
echo ""
echo " \$ cd $pluginName"
echo " \$ git remote add origin <repo URL>"
echo " \$ git push -u origin master"
echo ""
