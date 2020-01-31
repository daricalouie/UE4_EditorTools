#!/bin/bash

while [[ $pluginName == '' ]]
do
    read -p "provide your plugin name (do not use 'boilerplate' anywhere in your plugin name): " pluginName
done

git clone https://github.com/peetonn/UE4_BoilerplatePlugin.git $pluginName
cd $pluginName
./setup.sh $pluginName
