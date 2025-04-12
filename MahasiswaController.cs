namespace tpmodul9_2211104015
{
    using Microsoft.AspNetCore.Mvc;

    [ApiController]
    [Route("api/[controller]")]
    public class MahasiswaController : ControllerBase
    {
        private static List<Mahasiswa> data = new List<Mahasiswa>
    {
        new Mahasiswa { Nama = "Aufa Muhammad Isyfa'Lana", Nim = "2211104015" },
        new Mahasiswa { Nama = "Doanta Aloycius Ginting", Nim = "987654321" },
        new Mahasiswa { Nama = "Lintang Suminar Tyas Weni", Nim = "456789123" },
        new Mahasiswa { Nama = "Rezky Pratiwi", Nim = "321654987" }
    };

        [HttpGet]
        public ActionResult<List<Mahasiswa>> GetAll() => data;

        [HttpGet("{index}")]
        public ActionResult<Mahasiswa> Get(int index)
        {
            if (index < 0 || index >= data.Count) return NotFound();
            return data[index];
        }

        [HttpPost]
        public ActionResult Post([FromBody] Mahasiswa mhs)
        {
            data.Add(mhs);
            return Ok();
        }

        [HttpDelete("{index}")]
        public ActionResult Delete(int index)
        {
            if (index < 0 || index >= data.Count) return NotFound();
            data.RemoveAt(index);
            return Ok();
        }
    }

}
