function onSourceDownloadProgressChanged(sender, eventArgs)
{
    sender.findName("StatusText").Text = Math.round((eventArgs.progress * 100)) + "%";
    sender.findName("overlay").Width = 410 * eventArgs.progress;
    sender.findName("GridAnimation").Width = 410 * eventArgs.progress;
}