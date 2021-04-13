
# react-native-resizable-input

## Getting started

`$ npm install react-native-resizable-input --save`

### Mostly automatic installation

`$ react-native link react-native-resizable-input`

### Manual installation


#### iOS

1. In XCode, in the project navigator, right click `Libraries` ➜ `Add Files to [your project's name]`
2. Go to `node_modules` ➜ `react-native-resizable-input` and add `RNResizableInput.xcodeproj`
3. In XCode, in the project navigator, select your project. Add `libRNResizableInput.a` to your project's `Build Phases` ➜ `Link Binary With Libraries`
4. Run your project (`Cmd+R`)<

#### Android

1. Open up `android/app/src/main/java/[...]/MainActivity.java`
  - Add `import com.reactlibrary.RNResizableInputPackage;` to the imports at the top of the file
  - Add `new RNResizableInputPackage()` to the list returned by the `getPackages()` method
2. Append the following lines to `android/settings.gradle`:
  	```
  	include ':react-native-resizable-input'
  	project(':react-native-resizable-input').projectDir = new File(rootProject.projectDir, 	'../node_modules/react-native-resizable-input/android')
  	```
3. Insert the following lines inside the dependencies block in `android/app/build.gradle`:
  	```
      compile project(':react-native-resizable-input')
  	```

#### Windows
[Read it! :D](https://github.com/ReactWindows/react-native)

1. In Visual Studio add the `RNResizableInput.sln` in `node_modules/react-native-resizable-input/windows/RNResizableInput.sln` folder to their solution, reference from their app.
2. Open up your `MainPage.cs` app
  - Add `using Resizable.Input.RNResizableInput;` to the usings at the top of the file
  - Add `new RNResizableInputPackage()` to the `List<IReactPackage>` returned by the `Packages` method


## Usage
```javascript
import RNResizableInput from 'react-native-resizable-input';

// TODO: What to do with the module?
RNResizableInput;
```
  