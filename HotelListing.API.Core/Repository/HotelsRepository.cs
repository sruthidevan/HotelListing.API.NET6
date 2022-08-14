﻿using AutoMapper;
using HotelListing.API.Contracts;
using HotelListing.API.Data;

namespace HotelListing.API.Repository
{
    public class HotelsRepository : GenericRepository<Hotel>, IHotelsRepository
    {
        private readonly IMapper _mapper;

        public HotelsRepository(HotelListingDbContext context, IMapper mapper) : base(context, mapper)
        {
            this._mapper = mapper;
        }
    }
}
