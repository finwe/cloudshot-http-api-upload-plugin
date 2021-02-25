# CloudShot generic HTTP API upload plugin

A [CloudShot](https://cloudshot.com) plugin to upload the screenshot to a generic HTTP API

Built on [example plugin](https://github.com/name1ess0ne/CloudShot.Plugins/tree/main/PluginExample) for CloudShot version 6.3.x

## How to add the plugin to CloudShot

1. Download and install CloudShot from https://cloudshot.com/download.html
2. Copy `HttpApiPlugin.dll` from the [latest release](https://github.com/finwe/cloudshot-http-api-upload-plugin/releases)
	to `%USERPROFILE%/Documents/CloudShot/Plugins/HttpApiPlugin` folder.
	When updating the plugin with newer version, close CloudShot first.
3. Restart CloudShot. You should see **HTTP API Upload** item in Settings and also in Editor as a destination for screenshots upload.

## API expectations

This plugin sends a simple form-data HTTP POST request to the URL specified in plugin settings.
The only field in the request is `dataurl` with Base64-encoded image contents.
Accept header of the request is `text/plain`.

The plugin expects a `2xx` response of `text/plain` Content-type with the URL of the uploaded result. On other HTTP status codes
an error message is shown.

The URL of the request result is then copied to the clipboard based on selected copying style.
