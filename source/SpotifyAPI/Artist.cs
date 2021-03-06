// SpotifyAPI
// Copyright (C) 2014 Tim Potze
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT.
// IN NO EVENT SHALL THE AUTHORS BE LIABLE FOR ANY CLAIM, DAMAGES OR
// OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE,
// ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
// OTHER DEALINGS IN THE SOFTWARE.
// 
// For more information, please refer to <http://unlicense.org>

using System.Collections.Generic;
using Newtonsoft.Json;

namespace SpotifyAPI
{
    /// <summary>
    ///     Represents an artist.
    /// </summary>
    public class Artist : ResourcePromise<Artist.Resource>
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="Artist" /> class.
        /// </summary>
        /// <param name="name">The name of the artist.</param>
        /// <param name="uri">The uri of the artist.</param>
        internal Artist(string name, string uri)
            : base(name, uri)
        {
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="Artist" /> class.
        /// </summary>
        /// <param name="partialResource">The partial resource of the artist.</param>
        internal Artist(Resource partialResource)
            : base(partialResource)
        {
        }

        /// <summary>
        ///     Gets a collection of genres of this <see cref="Artist" />.
        /// </summary>
        public IEnumerable<string> Genres
        {
            get { return this["Genres"].Genres; }
        }

        /// <summary>
        ///     Gets a collection of images of this <see cref="Artist" />.
        /// </summary>
        public IEnumerable<ImageResource> Images
        {
            get { return this["Images"].Images; }
        }

        /// <summary>
        ///     Represents the json resource as provided by the API.
        /// </summary>
        public class Resource : BaseResource
        {
            [JsonProperty("genres")]
            public string[] Genres { get; set; }

            [JsonProperty("images")]
            public ImageResource[] Images { get; set; }
        }
    }
}