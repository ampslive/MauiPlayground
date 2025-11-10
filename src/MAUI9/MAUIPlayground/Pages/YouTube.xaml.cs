namespace MAUIPlayground.Pages;

public partial class YouTube : ContentPage
{
    public YouTube()
    {
        InitializeComponent();

        string htmlContent = @"
<html>
  <head>
    <style>
      * {
      margin: 0;
        padding: 0;
    }
      html, body {
width: 100%;
    height: 100%;
        overflow: hidden;
      }
  iframe {
    width: 100%;
        height: 100%;
        border: none;
     display: block;
      }
    </style>
  </head>
  <body>
    <iframe
      src='https://www.youtube.com/embed/QbRBqTPz_g4?rel=0&fs=0&modestbranding=1'
    frameborder='0'
      allowfullscreen
  ></iframe>
  </body>
</html>";

        var htmlSource = new HtmlWebViewSource
        {
            Html = htmlContent,
            BaseUrl = "https://amitphilips.com" // This sets the Referer
        };

        YoutubeWebView.Source = htmlSource;
    }
}