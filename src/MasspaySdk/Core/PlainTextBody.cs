/**
 * MassPay API
 *
 * The version of the OpenAPI document: 1.0.0
 * Contact: info@masspay.io
 *
 * NOTE: This file is auto generated.
 * Do not edit the file manually.
 */
using System.Net.Mime;
using System.Text;
using System.Net;

namespace MasspaySdk.Core;

public class PlainTextBody : IRequestBody
{
    private readonly string _body;

    public PlainTextBody(string body)
    {
        _body = body;
    }

    public HttpContent GetHttpContent()
    {
        return new StringContent(
          _body,
          Encoding.UTF8,
          MediaTypeNames.Text.Plain
        );
    }
}
